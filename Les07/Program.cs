using System.ComponentModel.DataAnnotations;

namespace Les07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DT
            //DateTime dateTime = new DateTime();
            //Console.WriteLine(dateTime);
            ////01.01.0001 00:00:00
            ////31.12.9999 23.59.59
            //Console.WriteLine(DateTime.MinValue);
            //Console.WriteLine(DateTime.MaxValue);

            //DateTime dateTime1 = new DateTime(2022, 11, 14);
            //Console.WriteLine(dateTime1);

            //DateTime dateTime2 = new DateTime(2022, 11, 14, 18, 40, 20);
            //Console.WriteLine(dateTime2);
            #endregion
            #region Now
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.UtcNow);

            //DateTime dt = DateTime.Now;

            //Console.WriteLine(DateTime.Today);

            //Console.WriteLine(dt.DayOfWeek);
            #endregion
            #region DayOfWeek
            //Console.WriteLine("Write year:");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine("Write month:");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("Write day:");
            //int day = int.Parse(Console.ReadLine());

            //DateTime date1 = new DateTime(year, month, day);

            //Console.WriteLine(date1.DayOfWeek);
            #endregion
            #region Add
            //DateTime date = DateTime.Now;
            //Console.WriteLine($"Now: {date}");
            //Console.WriteLine($"Now + 2days: {date.AddDays(2)}");
            //Console.WriteLine($"Now + 5H: {date.AddHours(5)}");
            //date.add
            //DateTime date2 = DateTime.Now.AddDays(5);
            #endregion
            #region Subtract
            //DateTime newYear = new DateTime(2023, 1, 1, 0, 0, 0);
            //Console.WriteLine(newYear.Subtract(DateTime.Now));
            //var sub = newYear.Subtract(DateTime.Now);

            ////auto qw = ...
            //int num = 5;
            //Console.WriteLine($"Days: {sub.Days}");
            //Console.WriteLine($"Hours: {sub.Hours}");
            #endregion
            #region Task2
            //DateTime dt = DateTime.Now;
            //DateTime dt2 = dt.AddDays(-5);
            //Console.WriteLine(dt2.DayOfWeek);

            //Console.WriteLine(DateTime.Now.AddDays(-5).DayOfWeek);
            #endregion
            int[,] matrix = new int[5, 5];
            bool isf = false;
            int k = 0;
            while (true)
            {
                if (k < 0)
                {
                    if (isf == false)
                    {
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                matrix[i, j] = 1;
                            }
                        }
                        isf = true;
                    }
                    else


                    {
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                matrix[i, j] = 0;
                            }
                        }
                        isf = false;
                    }
                    Console.Clear();
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                    k = 750000000;
                }
                k--;
            }
            //Thread.Sleep(...);
        }
    }
}