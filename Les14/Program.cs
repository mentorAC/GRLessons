using System.Globalization;

namespace Les14
{
    class Client
    {
        public int accountNumber;
        public string surname;
        public int sum;
        public DateTime date;
        public DateTime lastOperation;

        public Client()
        {
            accountNumber = -1;
            surname = "Nan";
            sum = -1;
            date = new DateTime();
            lastOperation = new DateTime();
        }
        public void AddMoney(int amount)
        {
            sum += amount;
            lastOperation = DateTime.Now;
        }
        public void GetMoney(int amount)
        {
            sum -= amount;
            lastOperation = DateTime.Now;
        }
        public void InsertInformation(int index)
        {
            Console.WriteLine($"{new String('-', 30)}");
            accountNumber = index + 1;
            Console.Write($"Account Surname: ");
            surname = Console.ReadLine();
            Console.Write($"Account Amount of Money: ");
            sum = int.Parse(Console.ReadLine());
            date = DateTime.Now;
            lastOperation = new DateTime();
            Console.WriteLine($"{new String('-', 30)}");
        }
        public void PrintInformation(int index)
        {
            Console.WriteLine($"Information about {index + 1} client ");
            Console.WriteLine($"{new String('-', 30)}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Surname: {surname}");
            Console.WriteLine($"Account Amount of Money: {sum}");
            Console.WriteLine($"Account was creat: {date}");
            Console.WriteLine($"{new String('-', 30)}");
        }
    }
    public class Timer
    {
        public DateTime start = DateTime.Now;
        public TimeSpan sec;

        public void Information()
        {
            sec = DateTime.Now - start;
            Console.WriteLine(new String('-', 30));
            Console.WriteLine($"Local Time: {DateTime.Now}");
            Console.WriteLine($"Timer:{sec.Minutes}:{sec.Seconds}");
            Console.WriteLine(new String('-', 30));
        }
    }

    //TURN ON
    //TURN OFF
    //SLEEP
    //REBOOT

    enum PCStatusType : byte
    {
        TURN_ON, TURN_OFF, SLEEP, REBOOT
    }

    class PC
    {
        private PCStatusType status;
        public void Action(PCStatusType status)
        {
            Console.WriteLine($"Change Status at {DateTime.Now}");

            this.status = status;
        }

        public void Information()
        {
            switch (status)
            {
                case PCStatusType.TURN_ON:
                    Console.WriteLine("PC is working!");
                    break;
                case PCStatusType.TURN_OFF:
                    Console.WriteLine("PC is not working!");
                    break;
                case PCStatusType.SLEEP:
                    Console.WriteLine("PC is sleeping!");
                    break;
                case PCStatusType.REBOOT:
                    Console.WriteLine("PC is rebooting!");
                    break;
            }
        }
    }


    class Person
    {
        private string name;
        private int age;

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region DZ
            #region MyRegion
            //    Console.Write($"How many people use bank: ");
            //    int peopleAmount = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"{new String('-', 30)}");
            //    Client[] clients = new Client[peopleAmount];
            //    for (int index = 0; index < clients.Length; index++)
            //    {
            //        Console.WriteLine($"Information about {index + 1} client ");
            //        clients[index] = new Client();
            //        clients[index].InsertInformation(index);
            //    }
            //    while (true)
            //    {
            //        Console.WriteLine($"Write 1 - number 2 - surname 3 - Exit");
            //        int variant = int.Parse(Console.ReadLine());
            //        if (variant == 3)
            //        {
            //            break;
            //        }
            //        if (variant == 1)
            //        {
            //            Console.Write($"Write Account Number:");
            //            int searchAccountNumber = int.Parse(Console.ReadLine());
            //            for (int i = 0; i < clients.Length; i++)
            //            {
            //                if (clients[i].accountNumber == searchAccountNumber)
            //                {
            //                    clients[i].PrintInformation(i);
            //                    Console.Write($"If this account your(1 - Yes 2 - No): ");
            //                    int isMyAccount = int.Parse(Console.ReadLine());
            //                    if (isMyAccount == 2)
            //                    {
            //                        Console.WriteLine($"You can try one more time");
            //                        break;
            //                    }
            //                    //else
            //                    //{
            //                    while (true)
            //                    {
            //                        Console.Write($"What action will you choose(1- Add money 2 - Get money 3 - Exit): ");
            //                        int action = int.Parse(Console.ReadLine());
            //                        if (action == 1)
            //                        {
            //                            Console.Write($"How much money do you want to deposit into the account: ");
            //                            int amount = int.Parse(Console.ReadLine());
            //                            clients[i].AddMoney(amount);
            //                            Console.WriteLine(new String('-', 30));
            //                            Console.WriteLine($"You have: {clients[i].sum} money");
            //                            Console.WriteLine(new String('-', 30));
            //                        }
            //                        if (action == 2)
            //                        {
            //                            Console.Write($"How much money do you want to get the account: ");
            //                            int amount = int.Parse(Console.ReadLine());
            //                            clients[i].GetMoney(amount);
            //                            Console.WriteLine(new String('-', 30));
            //                            Console.WriteLine($"You have: {clients[i].sum} money");
            //                            Console.WriteLine(new String('-', 30));
            //                        }
            //                        if (action == 3)
            //                        {
            //                            break;
            //                        }
            //                        // }
            //                    }
            //                }
            //            }
            //        }
            //        if (variant == 2)
            //        {
            //            Console.Write($"Write Account Surname:");
            //            string searchAccountSurname = Console.ReadLine();
            //            for (int i = 0; i < clients.Length; i++)
            //            {
            //                if (clients[i].surname == searchAccountSurname)
            //                {
            //                    clients[i].PrintInformation(i);
            //                    Console.Write($"If this your account(1 - Yes 2 - No): ");
            //                    int isaccount = int.Parse(Console.ReadLine());
            //                    if (isaccount == 2)
            //                    {
            //                        continue;
            //                    }

            //                    while (true)
            //                    {
            //                        Console.Write($"What action will you choose(1- Add money 2 - Get money 3 - Exit): ");
            //                        int action = int.Parse(Console.ReadLine());
            //                        if (action == 1)
            //                        {
            //                            Console.Write($"How much money do you want to deposit into the account: ");
            //                            int amount = int.Parse(Console.ReadLine());
            //                            clients[i].AddMoney(amount);
            //                            Console.WriteLine(new String('-', 30));
            //                            Console.WriteLine($"You have: {clients[i].sum} money");
            //                            Console.WriteLine(new String('-', 30));
            //                        }
            //                        if (action == 2)
            //                        {
            //                            Console.Write($"How much money do you want to get the account: ");
            //                            int amount = int.Parse(Console.ReadLine());
            //                            clients[i].GetMoney(amount);
            //                            Console.WriteLine(new String('-', 30));
            //                            Console.WriteLine($"You have: {clients[i].sum} money");
            //                            Console.WriteLine(new String('-', 30));
            //                        }
            //                        if (action == 3)
            //                        {
            //                            break;
            //                        }
            //                    }
            //                }
            //            }

            //        }
            //    }
            //    Console.WriteLine($"{new String('-', 30)}");
            //    bool isactive = false;
            //    for (int i = 0; i < clients.Length; i++)
            //    {
            //        if (clients[i].lastOperation == new DateTime())
            //        {
            //            Console.WriteLine($"account {i + 1} is not active");
            //        }
            //    }

            //}

            #endregion
            //Timer timer = new Timer();
            //while (true)
            //{
            //    timer.Information();
            //    Thread.Sleep(1000);
            //}
            #endregion
            #region Task1
            //const int TURN_ON = 1;
            //const int TURN_OFF = 2;
            //const int SLEEP = 3;

            //PC pC = new PC();


            //pC.Action((PCStatusType)TURN_ON);
            //pC.Information();

            //pC.Action(PCStatusType.SLEEP);
            //pC.Information();

            //PCStatusType pCStatusType;

            //pCStatusType = PCStatusType.SLEEP;

            //Console.WriteLine(pCStatusType);
            //Console.WriteLine((byte)pCStatusType);
            #endregion

            Person person = new Person();
            person.SetName("Tom");

            Console.WriteLine(person.GetName()) ;
        }
    }
}