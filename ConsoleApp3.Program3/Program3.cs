using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("your his name");
        var name = Console.ReadLine();
        Console.WriteLine("his age");
        var age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);

        Console.Write("What is your favorite day of week? ");

        var day = (DayOfWeek)int.Parse(Console.ReadLine());
        Console.WriteLine("Your favorite day is {0}", day);

    }
}