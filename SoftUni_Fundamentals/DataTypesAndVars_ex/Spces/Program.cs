using System;
namespace Spices
{
    class Program
    {
        static void Main(string[] args)
        {
            const int YIELD_DECREASE = 10;
            const int CONSUMED_BY_WORKERS = 26;
            const int IS_PROFITABLE = 100;

            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int totlalSpices = 0;

            while (yield >= IS_PROFITABLE)
            {
                days++;
                totlalSpices += yield;
                totlalSpices -= CONSUMED_BY_WORKERS;
                yield -= YIELD_DECREASE;
                if (yield < 100)
                {
                    totlalSpices -= CONSUMED_BY_WORKERS;
                }
            }
            Console.WriteLine(days);
            Console.WriteLine(totlalSpices);
        }
    }
}