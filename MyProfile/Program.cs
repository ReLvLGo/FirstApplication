using System;

class Mainclass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Как вас зовут?");
        var name = Console.ReadLine();
        Console.WriteLine("Сколько вам лет?");
        var age = Console.ReadLine();
        Console.WriteLine("Ваша дата рождения?");
        var birthday = Console.ReadLine();
        Console.WriteLine("Из какого вы города?");
        var city = Console.ReadLine();
        Console.WriteLine("Приятно познакомится {0} \nВам {1} лет \nВы родились {2} года \nВы из города {3}", name, age, birthday, city);
        Console.ReadLine(); 
    }
}