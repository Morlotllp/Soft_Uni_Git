using System;

namespace SumDigitsProgram
{
    class Program
    {
		public static int SumDigits(int inputInt)
		{
			string inputString = inputInt.ToString();
			int sumDigits = 0;

			for (int i = 0; i < inputString.Length; i++)
			{
				int currentDigit = int.Parse(inputString[i].ToString());
				sumDigits += currentDigit;
			}
			return sumDigits;
		}
		static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(SumDigits(input));
        }
    }
}
