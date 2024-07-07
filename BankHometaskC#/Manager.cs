namespace BankHometaskC_;

public class Manager : BankWorker,IManager
{
    public Manager(Guid guid, string name, string surname, int age, string position, double salary) : base(guid, name, surname, age, position, salary)
    {
    }

    public void CalculateSalary()
    {
        Console.WriteLine("Manager Calculate Salary");
    }

    public void organize()
    {
        Console.WriteLine("Manager organize");
    }
}
