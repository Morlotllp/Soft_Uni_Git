using System;

namespace TripplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            //ASCII lowercase letters range 97 - 122
                     
            for (int i = 0; i < num; i++)
            {
                int asciiIndex1 = i + 97;

                for (int j = 0; j < num; j++)
                {
                    int asciiIndex2 = j + 97;
                    for (int k = 0; k < num; k++)
                    {
                        int asciiIndex3 = k + 97;
                        Console.WriteLine($"{(char)asciiIndex1}{(char)asciiIndex2}{(char)asciiIndex3}");
                    }
                }
            }
        }
    }
}
