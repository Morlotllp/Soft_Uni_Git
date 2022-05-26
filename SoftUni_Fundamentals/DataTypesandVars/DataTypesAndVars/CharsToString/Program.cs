using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string finalString = null;

            for (int i = 0; i < 3; i++)
            {
                char input = char.Parse(Console.ReadLine());

                finalString += input;
            }
            Console.WriteLine(finalString);
        }
    }
}
