namespace BankHometaskC_;

public class CEO : BankWorker,ICEO
{
    public CEO(Guid guid, string name, string surname, int age, string position, double salary) : base(guid, name, surname, age, position, salary)
    {
    }

    public void control()
    {
        Console.WriteLine("Ceo Control...");
    }

    public void decreasePrecentage(double precent)
    {
        Console.WriteLine($"New Precenent: {precent}");
    }

    public void makeMeeting()
    {
        Console.WriteLine("Ceo meke Meeting");
    }

    public void organize()
    {
        Console.WriteLine("Ceo organize");
    }
}
