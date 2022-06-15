using System;

namespace Arrays_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] day = { "Monday", "Tuesday", "Wednesday" , "Thursday", "Friday", "Saturday", "Sunday" };
            int userInput = int.Parse(Console.ReadLine());

            if (userInput > 0 && userInput < 8)
            {
                Console.WriteLine(day[userInput - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
