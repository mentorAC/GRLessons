
using System.Text;
using Figgle;
namespace Les06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Trim
            //string email = "__myemail@gmai.com__";
            //Console.WriteLine(email.Trim('_'));
            //string email1 = "myemail@gmai.com";
            #endregion
            #region StringBuilder
            //StringBuilder stringBuilder = new StringBuilder("Start->");
            //stringBuilder.Append("1234");
            //stringBuilder.Append("6789");
            //stringBuilder.Append("qwer");

            //Console.WriteLine(stringBuilder);

            //StringBuilder sb = new StringBuilder();

            ////string s = "";
            //for (int i = 0; i < 1000000; i++)
            //{
            //    //s += i.ToString();
            //    //s += $"{i}";
            //    sb.Append($"{i}");
            //}
            //Console.WriteLine(sb.Length);
            //Console.WriteLine(s.Length);
            #endregion

            //char[] str = { 'h', 'e', 'l', 'l', 'o', '\0', 'w', 'o', 'r'};
            //string s = "123\04567👍🏻";//new(str);

            //Console.WriteLine(s);

            string text = "hello world";
            string newText = FiggleFonts.Standard.Render(text);

            Console.WriteLine(newText);

            Console.WriteLine(FiggleFonts.Graffiti.Render(text));
        }
    }
}