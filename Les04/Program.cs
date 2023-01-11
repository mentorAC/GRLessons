using System.Net.Http.Headers;

namespace Les04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int[,] matrix = new int[5, 10];

            //Console.WriteLine(matrix.Length);
            //Console.WriteLine(matrix.GetLength(0));
            //Console.WriteLine(matrix.GetLength(1));
            //Console.WriteLine(matrix.GetLength(2));
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //
            //    }
            //}

            //int[] arr3 = { 1, 2, 3 };
            //int[,] matrix2 =
            //{
            //    {1,2,3 },
            //    {4,5,6 },
            //    {7, 8, 9 }
            //};
            //
            //int[][] nums =
            //{
            //    new int[] {1,2},
            //    new int[] {1,2,3},
            //    new int[] {1,2,3,4},
            //    new int[] {1,2,3},
            //    new int[] {1,2},
            //};
            //
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums[i].Length; j++)
            //    {
            //        Console.Write($"{nums[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //
            //string[] lines =
            //{
            //    "one",
            //    "fourth",
            //    "hello",
            //    "word"
            //};
            //
            ////foreach
            //foreach (string word in lines)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region Task2
            //int heightcubes = int.Parse(Console.ReadLine());
            //int weighttcubes = int.Parse(Console.ReadLine());
            //int[,] paint = new int[heightcubes, weighttcubes];
            //
            //for(int i = 0; i < paint.GetLength(0); i++)
            //{
            //    for(int j= 0; j < paint.GetLength(1); j++)
            //    {
            //        if(i==0 || j==0 || j == paint.GetLength(1) - 1 
            //            || i == paint.GetLength(0)-1 || i == j || i+j ==paint.GetLength(1))
            //        {
            //            paint[i,j] = 1;
            //        }
            //    }
            //}
            //for (int i = 0; i < paint.GetLength(0); i++)
            //{
            //    for (int j = 0; j < paint.GetLength(1); j++)
            //    {
            //        //if(paint[i,j] == 1)
            //        //{
            //        //    Console.Write("*");
            //        //}
            //        //else
            //        //{
            //        //    Console.Write(" ");
            //        //}
            //        Console.Write((paint[i, j] == 1 ? "*" : " "));
            //        //Console.Write(paint[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            string s = "hello";
            //Console.WriteLine(s);
            //Console.WriteLine(s[3]);
            //s[3] = 'q';
            s = "word";
            //string('@', 10)

            string repeat = new string('@', 40);
            Console.WriteLine(repeat);

        }
    }
}