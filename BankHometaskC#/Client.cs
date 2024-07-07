namespace BankHometaskC_;

public class Client
{

    public Guid GudId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int age { get; set; }
    public string Live_Address { get; set; }
    public string Work_Address { get; set; }
    public double Salary { get; set; }
   public Credit Credit { get; set; }


    public Client( string name, string surname, int age, string live_Address, string work_Address, double salary, Credit credit)
    {
        GudId = Guid.NewGuid();
        Name = name;
        Surname = surname;
        this.age = age;
        Live_Address = live_Address;
        Work_Address = work_Address;
        Salary = salary;
        Credit = credit;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nSurname: {Surname}\nAge: {age}\n:Live Address: {Live_Address}\nWork Address: {Work_Address}\nSalary: {Salary}";
    }



}
