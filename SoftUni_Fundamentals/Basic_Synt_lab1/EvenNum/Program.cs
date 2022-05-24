using System;

namespace EvenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool even = false;

            while (even == false)
            {
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(input));
                    even = true;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}