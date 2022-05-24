using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string output = null;

            if (age <= 2 && age >= 0)
            {
                output = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                output = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                output = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                output = "adult";
            }
            else if (age >= 66)
            {
                output = "elder";
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.WriteLine(output);
        }
    }
}