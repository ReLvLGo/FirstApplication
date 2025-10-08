using System;


namespace FirstApplication.ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tКак \n вас зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            String Age = Console.ReadLine();
            Console.WriteLine("Какое ваше любимое хобби?");
            String Hobby = Console.ReadLine();
            Console.WriteLine("Здравствуйте, {0}", name);
            Console.WriteLine("Мне сообщили что вам {0} лет", Age);
            Console.WriteLine("{1} - это очень полезное занятие, так держать {0}", name, Hobby);
       Console.ReadKey();
        }

    }
}

