using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace philosophy;

public partial class Form1 : Form
{
    // Для задачи философов
    private List<Philosopher> philosophers = new List<Philosopher>();
    private List<Fork> forks = new List<Fork>();
    private List<Thread> threads = new List<Thread>(); //Список потоков
    private bool isDining = false;
    
    // Для задачи чтения XML
    private string xmlFilePath = "";
    
    public Form1()
    {
        InitializeComponent();
        InitializePhilosophers();
    }
    
    private void InitializePhilosophers()
    {
        // Создаем 5 вилок и философов
        for (int i = 0; i < 5; i++)
        {
            forks.Add(new Fork(i));
        } 
        for (int i = 0; i < 5; i++)
        {
            philosophers.Add(new Philosopher(i, forks[i], forks[(i + 1) % 5], UpdatePhilosopherStatus));
        }
    }
    
    //Обновление визуала статуса философа
    private void UpdatePhilosopherStatus(int id, string status)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<int, string>(UpdatePhilosopherStatus), id, status);
            return;
        }
        string newText = $"Философ {id+1}: {status}";
        Label[] philosopherLabels = { lblPhilosopher1, lblPhilosopher2, lblPhilosopher3, 
                                 lblPhilosopher4, lblPhilosopher5 };
        philosopherLabels[id].Text = newText;
    }
    
    //Кнопка запуска
    private void btnStartDining_Click(object sender, EventArgs e)
    {
        if (isDining)
        {
            StopDining();
            btnStartDining.Text = "Начать обед";
        }
        else
        {
            StartDining();
            btnStartDining.Text = "Остановить обед";
        }
    }
    
    private void StartDining()
    {
        isDining = true;
        threads.Clear();
        
        //Для каждого философа запускаем свой поток
        foreach (var philosopher in philosophers)
        {
            Thread thread = new Thread(() => philosopher.Dine(isDining));
            threads.Add(thread);
            thread.Start();
        }
    }
    
    //Асинхронное завершение, чтобы не зависал UI
    private async void StopDining()
    {
        isDining = false;
        
        await Task.Run(() => 
        {
            foreach (var thread in threads)
            {
                thread.Join(); // Блокируем каждый поток
            }
        });
        
        threads.Clear();
    }
    
    //Загрузка файла окном диалога
    private void btnBrowseXml_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            xmlFilePath = openFileDialog.FileName;
            txtXmlPath.Text = xmlFilePath;
        }
    }
    //Кнопка прочитать файл
    private void btnReadXml_Click(object sender, EventArgs e)
    {
        //Неккоректный ввод
        if (string.IsNullOrEmpty(xmlFilePath) || !File.Exists(xmlFilePath))
        {
            MessageBox.Show("Пожалуйста, выберите существующий XML файл");
            return;
        }
        
        try
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);
            
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            
            // Предполагаем, что первый элемент содержит все записи
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("*");
            
            if (nodes.Count > 0)
            {
                // Добавляем колонки на основе первого элемента
                foreach (XmlNode child in nodes[0].ChildNodes)
                {
                    dataGridView1.Columns.Add(child.Name, child.Name);
                }
                
                // Добавляем строки
                foreach (XmlNode node in nodes)
                {
                    List<string> rowValues = new List<string>();
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        rowValues.Add(child.InnerText);
                    }
                    dataGridView1.Rows.Add(rowValues.ToArray());
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при чтении XML: {ex.Message}");
        }
    }
    
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        StopDining();
        base.OnFormClosing(e);
    }
}
    



