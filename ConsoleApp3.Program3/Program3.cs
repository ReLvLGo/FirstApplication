using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите имя");
        string name = Console.ReadLine();
        Console.WriteLine("Введите возраст");
        var age =(Console.ReadLine());
        Console.WriteLine("ваше имя {0} \nваш возраст {1}", name, age);

        Console.WriteLine("Какой ваш любимый день недели?");
        
        week day = (week)int.Parse(Console.ReadLine());
      

        Console.WriteLine("Ваш любимый день недели {0}", day);
        Console.ReadKey();

    }
}
enum week : int
{
     MONDEY = 1,
        thusday = 2

}