using Figgle;

namespace Les08
{
    internal class Program
    {
        static void foo() => Console.WriteLine("qwerty");
        static int Sum(int a, int b) => a + b;

        static void PrintPerson(string name, int age = -1, string company = "Nan")
        {
            Console.WriteLine($"Name: {name} Age: {age} Company: {company}");
        }
        static void Main(string[] args)
        {
            #region To..
            //Console.WriteLine(DateTime.Now.ToLocalTime());
            //Console.WriteLine(DateTime.Now.ToUniversalTime());

            //Console.WriteLine(DateTime.Now.ToLongDateString());
            //Console.WriteLine(DateTime.Now.ToShortDateString());

            //Console.WriteLine(DateTime.Now.ToLongTimeString());
            //Console.WriteLine(DateTime.Now.ToShortTimeString());
            #endregion
            #region Task2
            //DateTime winter = new DateTime(2022, 11, 16, 14, 34, 17);
            //double d = 1.23456;
            //Console.WriteLine(d.ToString("#.###"));
            //16
            //Console.WriteLine(winter.ToString("dd/MM/yyyy -> HH:mm:ss"));
            //Console.WriteLine(winter.ToString("dd/MM/yyyy -> hh:mm:ss tt"));

            //DateTime dateTime = DateTime.Now;
            //string s = "";
            //for (int i = 0; i < 100000; i++)
            //{
            //    s += i.ToString();

            //}
            //DateTime dateTime2 = DateTime.Now;
            //Console.WriteLine(dateTime2.Subtract(dateTime).Milliseconds);
            #endregion
            //foo();

            Console.WriteLine(Sum(b: 2, a:1));

            PrintPerson("Tom", company:"Microsoft");
        }
    }
}