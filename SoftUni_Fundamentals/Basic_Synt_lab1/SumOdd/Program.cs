using System;
namespace SumOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOdds = int.Parse(Console.ReadLine());
            int sumOdds = 0;

            for (int i = 1; i <= numberOdds *2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sumOdds += i;
                }
            }
            Console.WriteLine("Sum: {0}",sumOdds);
        }
    }
}