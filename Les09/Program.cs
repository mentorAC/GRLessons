namespace Les09
{
    internal class Program
    {
        #region BubbleSort
        static void Swap(ref int e1, ref int e2)
        {
            int temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //3 2 7 1 4
        //2 3 7 1 4
        //2 3 1 7 4
        //2 3 1 4 7
        //2 3 1 4 7
        //2 1 3 4 7



        static int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        //Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }

        #endregion
        #region Lesson8Task3Insertion

        //3 2 1 7 4
        //2 1 3 7 4

        static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }

            return array;
        }

        #endregion
        #region Lesson8Task3Selection
        static int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }

            return result;
        }

        //static void Swap3(ref int x, ref int y)
        //{
        //    var t = x;
        //    x = y;
        //    y = t;
        //}

        //3 2 7 1 4
        //1 2 7 3 4
        //1 2 7 3 4
        //1 2 3 4 7

        static int[] SelectionSort(int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }

            return SelectionSort(array, currentIndex + 1);
        }
        #endregion
        #region Lesson8Task3Array
        static void Array()
        {
            Console.Write("Elements of array: ");
            var size = int.Parse(Console.ReadLine());//.Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 100); ;
            }
            var array1 = (int[])array.Clone();
            var array2 = (int[])array.Clone();
            var array3 = (int[])array.Clone();
            //var array1 = array;
            //var array2 = array;
            //var array3 = array;
            //Console.WriteLine($"Sorting array: {string.Join(", ", BubbleSort(array))}");

            int a = 10;
            int b = a;
            int c = a;


            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            DateTime dateTime = DateTime.Now;
            BubbleSort(array1);
            DateTime dateTime2 = DateTime.Now;
            var workingtime1 = dateTime2.Subtract(dateTime).Milliseconds;

            DateTime dateTime3 = DateTime.Now;
            InsertionSort(array2);
            DateTime dateTime4 = DateTime.Now;
            var workingtime2 = dateTime4.Subtract(dateTime3).Milliseconds;

            DateTime dateTime5 = DateTime.Now;
            SelectionSort(array3);
            DateTime dateTime6 = DateTime.Now;
            var workingtime3 = dateTime6.Subtract(dateTime5).Milliseconds;


            int redindex = 0;
            int greenindex = 0;
            if (workingtime1 > workingtime2 && workingtime1 > workingtime3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bubble Sorting Time is {workingtime1} Milliseconds");
                Console.ResetColor();
                greenindex = 1;
            }
            else if (workingtime1 < workingtime2 && workingtime1 > workingtime3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Insertion Sorting Time is {workingtime2} Milliseconds");
                Console.ResetColor();
                greenindex = 2;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Selection Sorting Time is {workingtime3} Milliseconds");
                Console.ResetColor();
                greenindex = 3;
            }

            if (workingtime1 < workingtime2 && workingtime1 < workingtime3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Bubble Sorting Time is {workingtime1} Milliseconds");
                Console.ResetColor();
                redindex = 1;
            }
            else if (workingtime1 > workingtime2 && workingtime1 < workingtime3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Insertion Sorting Time is {workingtime2} Milliseconds");
                Console.ResetColor();
                redindex = 2;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Selection Sorting Time is {workingtime3} Milliseconds");
                Console.ResetColor();
                redindex = 3;
            }

            if (greenindex == 1 && redindex == 2)
            {
                Console.WriteLine($"Selection Sorting Time is {workingtime3} Milliseconds");
            }
            else if (greenindex == 2 && redindex == 3)
            {
                Console.WriteLine($"Bubble Sorting Time is {workingtime1} Milliseconds");
            }
            else
            {
                Console.WriteLine($"Insertion Sorting Time is {workingtime2} Milliseconds");
            }

            DateTime standart1 = DateTime.Now;
            System.Array.Sort(array);
            DateTime standart2 = DateTime.Now;

            Console.WriteLine($"Standart sort: {standart2.Subtract(standart1).Milliseconds}");


        }
        #endregion

        //void foo(int& a)
        //{
        //    a++;
        //}

        static void Main(string[] args)
        {
            //Array();
        }
    }
}