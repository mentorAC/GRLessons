
#region struct
//PersonClass personClass;
//personClass.name = "qwertyu";

//PersonStruct personStruct = new PersonStruct("Tom");
//PersonStruct personStruct = new();
//with
//PersonStruct personStruct1 = personStruct with {name = "TOOOM"};
//personStruct.name = "Struct";
//personStruct.age = 1;

//personStruct.Print();
//personStruct1.Print();
//struct PersonStruct
//{
//    public string name;// = "Nan";---+
//                                  // +->public PersonStruct(){}
//    public int age;// = 1;-----------+
//    public PersonStruct():this("Nan")
//    {
//    }
//    public PersonStruct(string name):this(name, -1)
//    {
//        this.name = name;
//    }
//    public PersonStruct(string name, int age)
//    {
//        this.name = name;
//    }
//    public void Print() => 
//        Console.WriteLine($"Name: {name} Age: {age}");
//}

//class PersonClass
//{
//    public string name;
//    public int age;

//    public void Print()
//    {
//        Console.WriteLine($"Name: {name} Age: {age}");
//    }
//}

#endregion

//values types:
//byte, sbyte, short, ushort, int, uint, long, ulong
//float, double
//decimal
//bool
//char
//enum
//(struct)

//reference types
//object
//string
//(class)
//(interface)
//(delegate)


using System.Runtime.CompilerServices;

class Progarm
{
    static void Main(string[] srgs)
    {
        Calc(1);
    }

    static void Calc(int a)
    {
        int b = 5;
        int c = 10;
        int d = a + c;
    }
}
