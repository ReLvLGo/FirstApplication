using System;
class Program2
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("\tМойЛюбимыйДень");
        Semaphore color = (Semaphore) int.Parse(Console.ReadLine());
        Console.WriteLine(color);
      
    }
}

        enum Semaphore : short
        {
    Red = 100,
    Yellow = 200,
    Green = 300

} 


