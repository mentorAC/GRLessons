namespace Les03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HM
            /*Console.WriteLine("Write your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Write your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Write your School name:");
            string nameofSchool = Console.ReadLine();
            Console.WriteLine("Write your Pet name:");
            string nameofPet = Console.ReadLine();
            Console.WriteLine($"Your name is {name}. You are {age} year old. You study at {nameofSchool}. Your pet has name {nameofPet}");
            */
            //Random ran = new Random();

            //int zagadchuslo = ran.Next(1, 1000);
            //int vedenechuslo = 0;
            //while (vedenechuslo != zagadchuslo)
            //{
            //    Console.WriteLine("Write your number : ");
            //    vedenechuslo = int.Parse(Console.ReadLine());
            //    if (vedenechuslo == zagadchuslo)
            //    {
            //        Console.WriteLine("You win!!");
            //    }
            //    else if (vedenechuslo < zagadchuslo)
            //    {
            //        Console.WriteLine("You number is bigger number that i guessing");
            //    }
            //    else if (vedenechuslo > zagadchuslo)
            //    {
            //        Console.WriteLine("You number is less number that i guessing");
            //    }
            //}
            #endregion
            #region HM
            //Random rnd = new Random();
            //int randomchislo = rnd.Next(0, 100);
            //int a = 0;
            //Console.WriteLine("Write your first number:");
            //while (true)
            //{
            //    a = int.Parse(Console.ReadLine());
            //    if (a == randomchislo)
            //    {

            //        Console.WriteLine("|||||||||||||||||||||");
            //        Console.WriteLine("This number is right");
            //        Console.WriteLine("You win!!!!!");
            //        break;
            //    }
            //    string yesornot = (a < randomchislo) ? "Number higher" : "Number lower";
            //    Console.WriteLine("||||||||||||||||||||||||");
            //    Console.WriteLine(yesornot);
            //    Console.WriteLine("Write your next number:");
            //}
            #endregion
            #region Task1
            //Console.WriteLine("First");
            //goto m1;
            //Console.WriteLine("Second");
            //m1:
            //Console.WriteLine("Third");

            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //    Console.WriteLine("\n-------------\n");
            //    int q = 0;
            //m1:
            //    Console.Write($"{q} ");
            //    q++;
            //    if (q < 10)
            //    {
            //        goto m1;
            //    }
            #endregion
            #region Task2
            //int zalusshap = 0;
            //int vzavshap = 0;
            //int nadashap = 0;
            //for (int i = 0; i < 7; i++)
            //{
            //    int temperaura=int.Parse(Console.ReadLine());
            //    if (temperaura > 0)
            //    {
            //        zalusshap++;
            //    }
            //    else if(temperaura == 0)
            //    {
            //        vzavshap++;
            //    }
            //    else
            //    {
            //        nadashap++;
            //    }
            //}
            //Console.WriteLine($"Залишив шапку: {zalusshap} Взяв шапку: {vzavshap} Надягнув шапку: {nadashap}");
            #endregion

            //int[] arr = new int[10];
            //arr[3] = 10;

            //for (int i = 0; i < arr.Length; i++)
            //{

            //}

            //int[] arr = new int[5];
            //int min = int.MaxValue;
            //int max = int.MinValue;

            //int[] arr = new int[5];
            //int sumeven = 0;
            //int even1 = 0;
            //int maxx = int.MaxValue;
            //int minn = int.MinValue;

            //for (int i = 0; i < 5; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        sumeven += arr[i];
            //        even1++;

            //        if (arr[i] > maxx)
            //        {
            //            maxx = arr[i];
            //        }
            //        if (arr[i] < minn)
            //        {
            //            minn = arr[i];
            //        }
            //    }
            //}
            //Console.WriteLine($"sum: {sumeven}  amount: {even1}  min: {minn}  max: {maxx}");


            Console.WriteLine("First");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Second");
            Console.ResetColor();

            Console.WriteLine("Third");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Fourth");
            Console.ResetColor();

        }
    }
}