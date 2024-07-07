using CostomerException;

namespace BankHometaskC_
{
    public class Bank
    {
        public CEO CEO { get; set; }
        public string Name { get; set; }
        public long Budget { get; set; }
        public long Profit { get; set; }
        public List<Worker> Workers { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Client> Clients { get; set; }

        public Bank(CEO ceo, string name, long budget, long profit, List<Worker> workers, List<Manager> managers, List<Client> clients)
        {
            CEO = ceo;
            Name = name;
            Budget = budget;
            Profit = profit;
            Workers = workers ?? new List<Worker>();
            Managers = managers ?? new List<Manager>();
            Clients = clients ?? new List<Client>();
        }

        public void CalculateProfit()
        {
            Profit = Budget * 10 / 100;
        }

        public void ShowClientCredit(string name, string surname)
        {
            if (Clients == null || Clients.Count == 0)
            {
                throw new ListEmptyException("List is empty.");
            }

            foreach (Client client in Clients)
            {
                if (client.Name == name && client.Surname == surname)
                {
                    Console.WriteLine(client);
                    return;
                }
            }

            throw new ClientNotFoundException("Client not found.");
        }

        public void PayCredit(Client client, double money)
        {
            if (money < 0)
            {
                throw new InputException("Amount cannot be negative.");
            }

            if (Clients == null || Clients.Count == 0)
            {
                throw new ListEmptyException("List is empty.");
            }

            foreach (Client c in Clients)
            {
                if (c == client)
                {
                    c.Credit.amount -= money;
                    return;
                }
            }

            throw new ClientNotFoundException("Client not found.");
        }

        public void ShowAllcredit( Client client)
        {
            Console.WriteLine(client.Credit);
        }
    }
}