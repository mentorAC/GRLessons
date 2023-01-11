using System.Runtime.CompilerServices;

namespace Lesson21
{
    internal class Program
    {
        class Bank
        {
            private int Id { get; set; }
            private string Name { get; set; }
            private static int Bal { get; set; } = 500;

            public Bank(int id, string name)
            {
                Id = id;
                Name = name;
            }
            public void GetBalance(Client client)
            {
                Console.WriteLine($"{DateTime.Now} Name - {Name} Client Name - {client.Name} Balanc - {Bal}");
            }
            public void Add(Client client, int unit)
            {

                Bal += unit;
                Console.WriteLine($"{DateTime.Now} Name - {Name} ID - {Id} Client Name - {client.Name} Suma - {unit} NewBalanc - {Bal}");
            }
            public void Remove(Client client, int unit)
            {
                
                if (Bal - unit < 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"WRONG");
                    Console.ResetColor();
                    return;
                }
                Bal -= unit;
                Console.WriteLine($"{DateTime.Now} Name - {Name}ID - {Id} Client Name - {client.Name} Suma - {unit} NewBalanc - {Bal}");
            }
        }
        class Client
        {
            public string Name { get; set; }
            public string LastName { get; set; }
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank(1, "first");
            Bank bank2 = new Bank(2, "second");
            Client client = new Client();
            Console.Write("Your Name:");
            client.Name = Console.ReadLine();
            Console.Write("Your Last Name:");
            client.LastName = Console.ReadLine();

            while (true)
            {
                Console.WriteLine($"1 - Bal 2 - add 3 - remove 4 - exit");
                int id = int.Parse(Console.ReadLine());
                if (id == 1)
                {
                    bank.GetBalance(client);
                }
                if (id == 2)
                {
                    Console.Write($"How many: ");
                    int sum = int.Parse(Console.ReadLine());
                    bank.Add(client, sum);
                }
                if (id == 3)
                {
                    Console.Write($"How many: ");
                    int sum = int.Parse(Console.ReadLine());
                    bank.Remove(client, sum);
                }
                if (id == 4)
                {
                    return;
                }
            }
        }
    }
}