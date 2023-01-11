using System.Xml.Linq;

namespace Les02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HW
            //Console.Write("Ведіть ім'я ");
            //string name = Console.ReadLine();
            //
            //Console.Write("Ведіть вік ");
            //int year = int.Parse(Console.ReadLine());
            //
            //Console.WriteLine(name);
            //
            //Console.Write("Ваш вік ");
            //Console.WriteLine(year);
            //////
            //string s = Console.ReadLine();
            //int a = int.Parse(Console.ReadLine());
            //
            //Console.Write("Your name: ");
            //Console.WriteLine(s);
            //Console.Write("Your age : ");
            //Console.WriteLine(a);
            #endregion
            #region Task1
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //// <a> + <b> = <result>

            //Console.WriteLine(a + " + " + b + " = " + (a + b));


            //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            //string text = $"{a} + {b} = {a + b}";
            //Console.WriteLine(text);
            //Console.WriteLine("{a} + {b} = {a + b}");
            ////printf("Name = %s", "Tom")

            //string message = "Hello my {0} friend..";
            #endregion
            #region Task2
            //int a = int.Parse(Console.ReadLine());

            //double a = 1.2;

            //double d = double.Parse(Console.ReadLine());
            //Console.WriteLine(d);
            //Console.WriteLine(a);

            //string chuslo = (Console.ReadLine());
            //Console.WriteLine($"{chuslo[0]} {chuslo[1]} {chuslo[2]}");

            //int chuslo = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{chuslo/100} {(chuslo/10)%10} {chuslo%10}");
            #endregion

            //double a = 12.345678;
            //Console.WriteLine(a.ToString("0.000"));
            //Console.WriteLine($"{a:0.000}");

            //-a    -> uno
            //a-b   -> bi
            // ?:
            //(<умова>) ? <значення1> : <значення2>
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            
            int value = (a > b) ? a : b;
            Console.WriteLine(value);

            Console.WriteLine(((a > b) ? a : b));
            //if(a > b)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine(b);
            //}
        }
    }
}