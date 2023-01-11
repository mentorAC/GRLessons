using System.Net.Security;

namespace Les20
{

    class StaticMethods
    {
        public static void Method1()
        {
            Console.WriteLine("Hello world");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            StaticMethods.Method1();
            Console.WriteLine();
            Math.Sqrt(3);
        }
    }
}