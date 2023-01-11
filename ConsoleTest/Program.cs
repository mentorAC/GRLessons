using System;

namespace Lesson22Home
{
    class Logic
    {
        public static void Log()
        {
            while (true)
            {
                Console.WriteLine($"1 - Reverse 2 - Palindrom");
                int value = int.Parse(Console.ReadLine());
                if (value == 1)
                {
                    Console.Write($"Lenght of array: ");
                    int lenght = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Write your number:");
                    int[] arr = new int[lenght];
                    for (int i = 0; i < lenght; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    Algorithm.Reverse(arr);
                }
                if (value == 2)
                {

                    Console.Write($"Write your string: ");
                    string str = Console.ReadLine();
                    char[] delimiterChars = " ,.:\t?!".ToCharArray(); // { ' ', ',', '.', ':', '\t' };
                    string[] words = str.Split(" ,.:\t?!".ToCharArray());
                    str = string.Join(string.Empty, words);
                    
                    Algorithm.Palindrom(str);
                }
            }
        }
    }
    class Algorithm
    {
        private static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        public static void Reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - 1 - i]);
            }
        }
        public static void Palindrom(string str)
        {
            //string.Join("", words)

            bool isPal = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    isPal = false;
                }
            }
            if (isPal)
            {
                Console.WriteLine($"String is Palindrom");
            }
            else
            {
                Console.WriteLine($"String isn't Palindrom");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logic.Log();
        }
    }
}