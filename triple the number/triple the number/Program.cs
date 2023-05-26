using System;

namespace triple_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("hello please enter your number...");
            string number = Console.ReadLine();
            x = int.Parse(number);
            x *= 3;
            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}
