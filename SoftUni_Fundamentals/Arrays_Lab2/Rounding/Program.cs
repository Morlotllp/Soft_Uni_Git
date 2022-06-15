using System;
namespace Rounding
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrayParser = input.Split();

            double[] mainArray = new double[arrayParser.Length];

            for (int i = 0; i < arrayParser.Length; i++)
            {
                mainArray[i] = double.Parse(arrayParser[i]);
            }

            foreach (double item in mainArray)
            {
                Console.WriteLine($"{item} => {(int)Math.Round(item , MidpointRounding.AwayFromZero)}");
            }
        }
    }
}