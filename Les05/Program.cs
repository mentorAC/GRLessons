using System.Globalization;

namespace Les05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello WoRlD";
            string s2 = "WoRlD";
            #region Contains
            //Contains
            //if (s1.Contains(s2))
            //{
            //    Console.WriteLine("Yes");
            //}
            #endregion
            #region Concat
            //string s3 = s1 + s2;
            //string s4 = string.Concat(s1, s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            #endregion
            #region IndexOf
            //int index = s1.IndexOf(s2);
            //Console.WriteLine(index);
            #endregion
            #region Insert
            //string s3 = s1.Insert(0, s2);
            //Console.WriteLine(s3);
            #endregion
            #region Join
            //int[] num = {1,2,3,4,5};
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.Write($"{num[i]} ");
            //}
            //string s3 = string.Join(" ", num);
            //Console.WriteLine(string.Join(">-<", num));
            #endregion
            #region Upper Lower
            //Console.WriteLine(s2.ToUpper());
            //Console.WriteLine(s2.ToLower());
            #endregion
            string str = "Hello everybody I like c#";
            string[] words = str.Split(" ");
            foreach (var word in words)
            {
                Console.WriteLine($"{word}{{{words.Length}}}");
            }
            
        }
    }
}