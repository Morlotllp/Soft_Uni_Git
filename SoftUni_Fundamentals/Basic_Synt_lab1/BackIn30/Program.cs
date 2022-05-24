using System;

namespace BackIn30
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int result = minutes + 30;

            if (result > 59)
            {
                result -= 60;
                hours += 1;
            }
            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine("{0}:{1:d2}", hours, result);
        }
    }
}