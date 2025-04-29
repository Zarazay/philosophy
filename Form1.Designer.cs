namespace philosophy;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.btnStartDining = new System.Windows.Forms.Button();
        this.lblPhilosopher1 = new System.Windows.Forms.Label();
        this.lblPhilosopher2 = new System.Windows.Forms.Label();
        this.lblPhilosopher3 = new System.Windows.Forms.Label();
        this.lblPhilosopher4 = new System.Windows.Forms.Label();
        this.lblPhilosopher5 = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.btnReadXml = new System.Windows.Forms.Button();
        this.btnBrowseXml = new System.Windows.Forms.Button();
        this.txtXmlPath = new System.Windows.Forms.TextBox();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();
        
        // 
        // btnStartDining
        // 
        this.btnStartDining.Location = new System.Drawing.Point(20, 30);
        this.btnStartDining.Name = "btnStartDining";
        this.btnStartDining.Size = new System.Drawing.Size(150, 30);
        this.btnStartDining.TabIndex = 0;
        this.btnStartDining.Text = "Начать обед";
        this.btnStartDining.UseVisualStyleBackColor = true;
        this.btnStartDining.Click += new System.EventHandler(this.btnStartDining_Click);
        
        // 
        // lblPhilosopher1
        // 
        this.lblPhilosopher1.AutoSize = true;
        this.lblPhilosopher1.Location = new System.Drawing.Point(20, 80);
        this.lblPhilosopher1.Name = "lblPhilosopher1";
        this.lblPhilosopher1.Size = new System.Drawing.Size(85, 15);
        this.lblPhilosopher1.TabIndex = 1;
        this.lblPhilosopher1.Text = "Философ 1: -";
        
        // 
        // lblPhilosopher2
        // 
        this.lblPhilosopher2.AutoSize = true;
        this.lblPhilosopher2.Location = new System.Drawing.Point(20, 110);
        this.lblPhilosopher2.Name = "lblPhilosopher2";
        this.lblPhilosopher2.Size = new System.Drawing.Size(85, 15);
        this.lblPhilosopher2.TabIndex = 2;
        this.lblPhilosopher2.Text = "Философ 2: -";
        
        // 
        // lblPhilosopher3
        // 
        this.lblPhilosopher3.AutoSize = true;
        this.lblPhilosopher3.Location = new System.Drawing.Point(20, 140);
        this.lblPhilosopher3.Name = "lblPhilosopher3";
        this.lblPhilosopher3.Size = new System.Drawing.Size(85, 15);
        this.lblPhilosopher3.TabIndex = 3;
        this.lblPhilosopher3.Text = "Философ 3: -";
        
        // 
        // lblPhilosopher4
        // 
        this.lblPhilosopher4.AutoSize = true;
        this.lblPhilosopher4.Location = new System.Drawing.Point(20, 170);
        this.lblPhilosopher4.Name = "lblPhilosopher4";
        this.lblPhilosopher4.Size = new System.Drawing.Size(85, 15);
        this.lblPhilosopher4.TabIndex = 4;
        this.lblPhilosopher4.Text = "Философ 4: -";
        
        // 
        // lblPhilosopher5
        // 
        this.lblPhilosopher5.AutoSize = true;
        this.lblPhilosopher5.Location = new System.Drawing.Point(20, 200);
        this.lblPhilosopher5.Name = "lblPhilosopher5";
        this.lblPhilosopher5.Size = new System.Drawing.Size(85, 15);
        this.lblPhilosopher5.TabIndex = 5;
        this.lblPhilosopher5.Text = "Философ 5: -";
        
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.lblPhilosopher1);
        this.groupBox1.Controls.Add(this.lblPhilosopher5);
        this.groupBox1.Controls.Add(this.btnStartDining);
        this.groupBox1.Controls.Add(this.lblPhilosopher4);
        this.groupBox1.Controls.Add(this.lblPhilosopher2);
        this.groupBox1.Controls.Add(this.lblPhilosopher3);
        this.groupBox1.Location = new System.Drawing.Point(20, 20);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(300, 250);
        this.groupBox1.TabIndex = 6;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Обедающие философы";
        
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.dataGridView1);
        this.groupBox2.Controls.Add(this.btnReadXml);
        this.groupBox2.Controls.Add(this.btnBrowseXml);
        this.groupBox2.Controls.Add(this.txtXmlPath);
        this.groupBox2.Location = new System.Drawing.Point(350, 20);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(450, 400);
        this.groupBox2.TabIndex = 7;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Чтение XML файла";
        
        // 
        // btnReadXml
        // 
        this.btnReadXml.Location = new System.Drawing.Point(300, 30);
        this.btnReadXml.Name = "btnReadXml";
        this.btnReadXml.Size = new System.Drawing.Size(120, 25);
        this.btnReadXml.TabIndex = 2;
        this.btnReadXml.Text = "Прочитать";
        this.btnReadXml.UseVisualStyleBackColor = true;
        this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
        
        // 
        // btnBrowseXml
        // 
        this.btnBrowseXml.Location = new System.Drawing.Point(20, 30);
        this.btnBrowseXml.Name = "btnBrowseXml";
        this.btnBrowseXml.Size = new System.Drawing.Size(120, 25);
        this.btnBrowseXml.TabIndex = 1;
        this.btnBrowseXml.Text = "Выбрать файл";
        this.btnBrowseXml.UseVisualStyleBackColor = true;
        this.btnBrowseXml.Click += new System.EventHandler(this.btnBrowseXml_Click);
        
        // 
        // txtXmlPath
        // 
        this.txtXmlPath.Location = new System.Drawing.Point(150, 30);
        this.txtXmlPath.Name = "txtXmlPath";
        this.txtXmlPath.ReadOnly = true;
        this.txtXmlPath.Size = new System.Drawing.Size(140, 23);
        this.txtXmlPath.TabIndex = 0;
        
        // 
        // dataGridView1
        // 
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new System.Drawing.Point(20, 70);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.Size = new System.Drawing.Size(400, 300);
        this.dataGridView1.TabIndex = 3;
        
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(820, 450);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.Name = "Form1";
        this.Text = "Философы и XML Reader";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnStartDining;
    private System.Windows.Forms.Label lblPhilosopher1;
    private System.Windows.Forms.Label lblPhilosopher2;
    private System.Windows.Forms.Label lblPhilosopher3;
    private System.Windows.Forms.Label lblPhilosopher4;
    private System.Windows.Forms.Label lblPhilosopher5;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnReadXml;
    private System.Windows.Forms.Button btnBrowseXml;
    private System.Windows.Forms.TextBox txtXmlPath;
    private System.Windows.Forms.DataGridView dataGridView1;
}
