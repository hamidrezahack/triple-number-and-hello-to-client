using System;

namespace hello_to_client
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter your name...");
            var name = Console.ReadLine();
            Console.WriteLine("hello " + name);
            Console.WriteLine("press any key to end...");
            Console.ReadKey();
        }
    }
}
