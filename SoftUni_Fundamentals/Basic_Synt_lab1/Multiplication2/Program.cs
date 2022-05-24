using System;

namespace Multy2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
                }
            }
            else
            {
                Console.WriteLine("{0} X {1} = {2}", num, multiplier, num * multiplier);
            }
        }
    }
}