namespace Les12
{

    class MyDate
    {
        public int day;
        public int month;
        public int year;

        public void Print()
        {
            Console.WriteLine($"{day}.{month}.{year}");
        }
    }


    class Human
    {
        public string name;
        public string surname;
        public int height;
        public int age;

        public void Print()
        {
            Console.WriteLine($"Name: {name}\nSurname: {surname}\nHeight:{height}\nAge: {age}");
        }

    }

    class Program
    {
        static void FillDate(MyDate d)
        {
            d.day = 100;
            d.month= 100;
            d.year = 100;
        }

        static void Main(string[] args)
        {
            #region Start date
            //int l = 123;

            //int day = 1;
            //int month = 1;
            //int year = 1;

            //int day1 = 1;
            //int month1 = 1;
            //int year1 = 1;

            //int[] days = new int[50];
            //int[] months = new int[50];
            //int[] years = new int[50];
            #endregion
            MyDate date = new MyDate();
            FillDate(date);
            date.Print();

            //Human person = new Human();
            //person.name = "David";
            //person.surname = "Vlos";
            //person.height = 180;
            //person.age = 30;
            //person.Print();

            //int a;
            //Console.WriteLine(a);

        }
    }
}