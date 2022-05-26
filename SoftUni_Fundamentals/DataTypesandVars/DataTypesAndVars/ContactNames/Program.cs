using System;

namespace ContactNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string delimer = Console.ReadLine();

            Console.WriteLine($"{name1}{delimer}{name2}");
        }
    }
}
