using System;

namespace NumsInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsToEnter = int.Parse(Console.ReadLine());

            int[] numsArray = new int[numsToEnter];

            for (int i = 0; i < numsToEnter; i++)
            {
                int input = int.Parse(Console.ReadLine());

                numsArray[i] = input;
            }

            for (int i = numsArray.Length; i > 0; i--)
            {
                Console.Write(numsArray[i - 1] + " ");
            }
        }
    }
}
