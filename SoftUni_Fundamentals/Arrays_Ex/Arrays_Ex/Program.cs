using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonNumber = int.Parse(Console.ReadLine());
            int[] passengers = new int[wagonNumber];
            int totalPassengers = 0;

            for (int i = 0; i < wagonNumber; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                totalPassengers += passengers[i];
            }

            foreach (int item in passengers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n" + totalPassengers);
        }
    }
}
