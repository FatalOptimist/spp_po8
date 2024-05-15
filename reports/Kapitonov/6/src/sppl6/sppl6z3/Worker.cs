namespace sppl6z3;

public class Worker
{
    public static Worker Director = new Worker("Director", "IT", "Director", 100000);

    public static void CalculateSalary(Worker worker)
    {
        if (worker.Boss == null)
        {
            worker.ShowSalary();
        }
        worker.Subordinates.ForEach(x=> x.ShowSalary());
        worker.Subordinates.ForEach(CalculateSalary);
    }

    public  void ShowSalary()
    {
        Console.WriteLine($"Name: {Name}, Salary: {Salary}");
    }
    
    public static void AddWorker(Worker boss, Worker newWorker)
    {
        boss.Subordinates.Add(newWorker);
        newWorker.Boss = boss;
    }

    public static void DeleteWorker(Worker worker)
    {
        worker.Boss?.Subordinates.AddRange(worker.Subordinates);
        worker.Boss?.Subordinates.Remove(worker);
        worker.Subordinates.Clear();
    }
    

    public Worker(string name, string department, string jobTitle, decimal salary)
    {
        Name = name;
        Department = department;
        JobTitle = jobTitle;
        Salary = salary;
        Subordinates = new List<Worker>();
        Boss = null;
    }

    public string Name { get; set; }
    public string Department { get; set; }
    public string JobTitle { get; set; }
    public decimal Salary { get; set; }
    
    public List<Worker> Subordinates { get; set; }
    
    public Worker? Boss { get; set; }
}