using System;

class Program3
{
    public static void Main (string[] args)
    {
        string Myname = "Comp";
        Console.WriteLine("Haloo human");
        Console.WriteLine("Меня зовут {0}", Myname);
        Console.WriteLine("а как зовут тебя?");
       string yourname = Console.ReadLine();
        Console.WriteLine("Приятно познакомится {0}", yourname);
        Console.ReadKey();

    }
}