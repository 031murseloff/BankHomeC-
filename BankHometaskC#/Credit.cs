namespace BankHometaskC_;

public class Credit
{
   

    public Guid CreditId { get; set; }

    

    public double amount { get; set; }

    public double precent { get; set; }

    public int month { get; set; }

    public Credit( double amount, double precent, int month)
    {
        CreditId = Guid.NewGuid();
        this.amount = amount;
        this.precent = precent;
        this.month = month;
    }

    public void Calculateprecent()
    {
        Console.WriteLine("Ayliq faiz hesablandi...");
    }
    public void Pay()
    {
        Console.WriteLine("Ayliq credit odenildi...");
    }

    public override string ToString()
    {
        return $"Amount: {amount}\nPrecent: {precent}\nMonth: {month}";
    }


}
