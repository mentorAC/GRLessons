Area area1 = new Area(); //-> Stack
Area area2 = new Area(); //-> Stack

area2.x = 1;
area2.y = 2;
area1 = area2;
area2.x = 5;
Console.WriteLine(area1.x);//1
Console.WriteLine(area2.x);//5

Country country1 = new();//-> Heap
Country country2 = new();//-> Heap

country2.x = 1;
country2.y = 4;
country1 = country2;
country2.x = 7;

Console.WriteLine(country1.x);//7
Console.WriteLine(country2.x);//7


struct Area
{
    public int x;
    public int y;
    public Country country;

    public Area()
    {
        x = 0;
        y = 0;
        country = new Country();
    }
}

class Country
{
    public int x = 0;
    public int y = 0;
}