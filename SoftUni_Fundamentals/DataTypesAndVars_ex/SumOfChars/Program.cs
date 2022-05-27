using System;

namespace SumOfChars
{
    class Program
    {
        static int Converter()
        {
            char input = Convert.ToChar(Console.ReadLine());
            int asciiNum = Convert.ToInt32(input);
            return asciiNum;
        }
        static void Main(string[] args)
        {
            int numberOfChars = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numberOfChars; i++)
            {
                int currentChar = Converter();
                sum += currentChar;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
