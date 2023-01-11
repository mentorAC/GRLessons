using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Les13
{
    class Lampa
    {
        private bool isOn;
        public void On()
        {
            isOn = true;
        }
        public void Off()
        {
            isOn = false;
        }
        public void Status()
        {
            if (isOn)
            {
                Console.WriteLine("Lampa is On");
            }
            else
            {
                Console.WriteLine("Lampa is Off");
            }
        }
    }

    class Car
    {
        private string model;
        private string mark;

        public void Info()
        {
            Console.WriteLine($"Mark: {mark }\n" +
                              $"Model: {model}");
            Console.WriteLine(new string('-', 10));
        }
        //public Car()
        //{
        //    Console.WriteLine("Constructor!");
        //}

        public Car(string model, string mark)
        {
            this.model = model;
            this.mark = mark;
        }
    }

    //Human
    //Name => Nan
    //Age => -1
    //Company => Nan
    class Human
    {
        public string name;
        public int age;
        public string company;

        public void Info()
        {
            Console.WriteLine($"Name: {name} Age: {age} Company: {company}");
        }

        public Human()
        {
            name = "Nan";
            age = -1;
            company = "Nan"; 
        }

        public Human(string name)
        {
            
           this.name = name;
           age = -1;
           company = "Nan";
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Car
            //Car car = new Car();
            //car.mark = "WW";
            //car.model = "Passat b6";
            //car.Info();

            //Car car1 = new Car("Q3", "BMW");

            //car1.Info();


            ////car1.mark = "Lada";
            ////car1.model = "2107";
            //car1.Info();

            //Car car2 = new Car();
            //car2.Info();
            #endregion
            #region Lamp
            //Lampa lampa = new Lampa();
            //lampa.Status();
            //lampa.On();
            //lampa.Status();

            //lampa.Off();
            //lampa.Status();

            //lampa.isOn
            #endregion
        }
    }
}