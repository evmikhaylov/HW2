using System;


namespace HELLO_WORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello");
            Console.Write("World");
            Console.Write("!!!");

            Console.WriteLine("\nHello ");
            Console.WriteLine("World ");
            Console.WriteLine("!!! ");
            Console.WriteLine("Нажать ENTER  для выхода");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
    }
}
