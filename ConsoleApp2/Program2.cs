using System;
class Program2
{
    public static void Main(string[] args)
    {
        Semaphore МойЛюбимыйДень;
        МойЛюбимыйДень = Semaphore.Red;
        Console.WriteLine("\tМойЛюбимыйДень");
        Console.ReadKey();
      
    }
}

        enum Semaphore : short
        {
    Red = 100,
    Yellow = 200,
    Green = 300

} 


