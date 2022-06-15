using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string[] reversed = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                reversed[i] = input[i];
            }

            for (int i = reversed.Length; i > 0; i--)
            {
                Console.Write(reversed[i - 1] + " ");
            }
        }
    }
}
