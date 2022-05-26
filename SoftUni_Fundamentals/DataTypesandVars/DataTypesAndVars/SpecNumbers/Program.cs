using System;

namespace SpecNumbers
{
    class Program
    {
        static int CalculateDigits(int inputS)
        {
            string input = inputS.ToString();
            int sumDigits = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int digit = Convert.ToInt32(input[i].ToString());
                sumDigits += digit;
            }
            return sumDigits;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int convertInput = int.Parse(input);
            bool isSpecial = false;

            for (int i = 1; i <= convertInput; i++)
            {
                int currentNum = CalculateDigits(i);
                if (currentNum  == 5 || currentNum == 7 || currentNum == 11)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");

                currentNum = 0;
                isSpecial = false;
            }
            
        }
    }
}
