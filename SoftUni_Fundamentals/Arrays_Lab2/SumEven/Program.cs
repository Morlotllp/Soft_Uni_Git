using System;

namespace SumEven
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sumEven = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = int.Parse(input[i]);
                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
            }
            Console.WriteLine(sumEven);
        }
    }
}
