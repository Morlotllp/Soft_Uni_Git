using System;

namespace EvenOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = int.Parse(input[i]);

                if (currentNum % 2 == 0)
                {
                    sumEven += currentNum;
                }
                else
                {
                    sumOdd += currentNum;
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
