﻿using System;
namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = start; i <= stop; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}