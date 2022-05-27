using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] dumpBin = new char[3];

            for (int i = 0; i < 3; i++)
            {
                char character = char.Parse(Console.ReadLine());
                dumpBin[i] = character;
            }

            for (int i = dumpBin.Length; i > 0; i--)
            {
                Console.Write(dumpBin[i - 1] + " ");
            }
        }
    }
}
