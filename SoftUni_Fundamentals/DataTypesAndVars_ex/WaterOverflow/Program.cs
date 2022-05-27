using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int pourTimes = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int litresPoured = 0;

            for (int i = 0; i < pourTimes; i++)
            {
                int waterQuantity = int.Parse(Console.ReadLine());

                if (waterQuantity > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");

                }
                else
                {
                    litresPoured += waterQuantity;
                    tankCapacity -= waterQuantity;
                }
            }
            Console.WriteLine(litresPoured);
        }
    }
}
