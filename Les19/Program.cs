using System.Runtime.ExceptionServices;

namespace Les19
{

    class Anything
    {
        public static int StatValue { get; set; }
        public int Value { get; set; } = 1;

        public int GetStatValue()
        {
            return StatValue;
        }

    }

    internal class Program
    {
        static void Main1(string[] args)
        {
            Anything first = new Anything();
            Anything second = new();

            first.Value = 6;
            Console.WriteLine(first.Value);
            Console.WriteLine(second.Value);
            Console.WriteLine("\n----------\n");

            Anything.StatValue = 100;
            Console.WriteLine(first.GetStatValue());
            Console.WriteLine(second.GetStatValue());
        }
    }
}


//ВідділенняБанку: //500
//Поля:
//-номер
//-назва
//конструктор: (номер, назва)
//Методи:
//-переглянути баланс -> |дата, ім'я клієнт, баланс
//-покласти грощі на рахцнок -> | дата, клієнт, інформація про відділення, сума, новий баланс (зелений)
//-зняти грощі -> | дата, клієнт, інформація про відділення, сума(яка була знята), новий баланс(червоним)
//помилка - має свій колір

//клієнт - окремий клас