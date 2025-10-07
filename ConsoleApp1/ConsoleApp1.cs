using System;
class ConsoleApp1
{
    public static void Main(string[] args)
    {
        string MyName = "Дмитрий";
        byte age = 35;
        bool HaveIApet = true;
        double MyShoeSize = 42.5;

        Console.WriteLine("Меня зовут " + MyName);
        Console.WriteLine("Мне " + age + " лет");
        Console.WriteLine("Есть ли у меня питомец? " + HaveIApet);
        Console.WriteLine("Мой размер ноги " + MyShoeSize);
    }
}