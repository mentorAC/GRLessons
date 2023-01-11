namespace Les11
{
    internal class Program
    {

        static void Inc(int a)//10
        {
            Console.WriteLine("Inc for var");
            a++;
        }
        static void IncRef(ref int a)
        {
            Console.WriteLine("IncRef for var");
            a++;
        }
        static void IncRef(ref int[] arr)//0xAF6BC
        {
            Console.WriteLine("IncRef for array");
            arr = new int[] {1,2,3,4,5 };
        }
        static void Inc(int[] arr)//0xAF6BC
        {
            Console.WriteLine("Inc for array");
            Array.Fill(arr, 1);
        }

        //in
        //out

        //void foo(in int a)
        //{
        //    a++;
        //}

        static void Method(out int a)
        {
            a = 100;
        }

        static void Main(string[] args)
        {
            #region 
            //Console.WriteLine("Hello, World!");

            //int a = 10;

            //int[] arr = new int[5];//0xAF6BC

            //Console.WriteLine($"A = {a}");
            //Inc(a);
            //Console.WriteLine($"A = {a}");

            //Console.WriteLine($"Arr: {string.Join(" ", arr)}");
            //Inc(arr);
            //Console.WriteLine($"Arr: {string.Join(" ", arr)}");

            //Console.WriteLine("\n<------------------>\n");

            //Console.WriteLine($"A = {a}");
            //IncRef(ref a);
            //Console.WriteLine($"A = {a}");

            //Console.WriteLine($"Arr: {string.Join(" ", arr)}");//0xAF6BC
            //IncRef(ref arr);
            //Console.WriteLine($"Arr: {string.Join(" ", arr)}");//0xCB7A1
            #endregion

            //int a = 1;
            //Console.WriteLine(a);
            //Method(out a);
            //Console.WriteLine(a);

            string data = Console.ReadLine();
            //int value;
            if (!int.TryParse(data, out int value))
            {
                Console.WriteLine("Error parse");
            }
            else
            {
                Console.WriteLine(value) ;
            }
            int a = 10;

            
        }
    }
}