namespace BankHometaskC_
{
    public abstract class BankWorker
    {
       

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int age { get; set; }
        public string position { get; set; }
        public double salary { get; set; }

        protected BankWorker(Guid guid, string name, string surname, int age, string position, double salary)
        {
            Guid = Guid.NewGuid();
            Name = name;
            Surname = surname;
            this.age = age;
            this.position = position;
            this.salary = salary;
        }




    }
}
