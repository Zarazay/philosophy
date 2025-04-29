// Класс вилки
public class Fork
{
    public int Id { get; private set; }
    private object lockObj = new object();
    
    public Fork(int id)
    {
        Id = id;
    }
    
    public bool PickUp()
    {
        return Monitor.TryEnter(lockObj);
    }
    
    public void PutDown()
    {
        Monitor.Exit(lockObj);
    }
}

// Класс философа
public class Philosopher
{
    public int Id { get; private set; }
    private Fork leftFork;
    private Fork rightFork;
    private Action<int, string> updateStatus;
    private Random random = new Random();
    
    public Philosopher(int id, Fork leftFork, Fork rightFork, Action<int, string> updateStatus)
    {
        Id = id;
        this.leftFork = leftFork;
        this.rightFork = rightFork;
        this.updateStatus = updateStatus;
    }
    
    public void Dine(bool isDining)
    {
        while (isDining)
        {
            // Думаем
            updateStatus(Id, "Думает");
            Thread.Sleep(random.Next(1000, 3000));
            
            // Пытаемся поесть
            updateStatus(Id, "Голоден");
            
            bool hasLeftFork = false;
            bool hasRightFork = false;
            
            try
            {
                // Пытаемся взять левую вилку
                hasLeftFork = leftFork.PickUp();
                if (hasLeftFork)
                {
                    updateStatus(Id, $"Взял левую вилку {leftFork.Id}");
                    
                    // Пытаемся взять правую вилку
                    hasRightFork = rightFork.PickUp();
                    if (hasRightFork)
                    {
                        updateStatus(Id, $"Взял правую вилку {rightFork.Id}");
                        
                        // Едим
                        updateStatus(Id, "Ест");
                        Thread.Sleep(random.Next(1000, 3000));
                    }
                    else
                    {
                        updateStatus(Id, "Не может взять правую вилку");
                    }
                }
                else
                {
                    updateStatus(Id, "Не может взять левую вилку");
                }
            }
            finally
            {
                // Всегда кладем вилки обратно
                if (hasRightFork)
                {
                    rightFork.PutDown();
                    updateStatus(Id, $"Положил правую вилку {rightFork.Id}");
                }
                
                if (hasLeftFork)
                {
                    leftFork.PutDown();
                    updateStatus(Id, $"Положил левую вилку {leftFork.Id}");
                }
            }
        }
        
        updateStatus(Id, "Закончил обед");
    }
}