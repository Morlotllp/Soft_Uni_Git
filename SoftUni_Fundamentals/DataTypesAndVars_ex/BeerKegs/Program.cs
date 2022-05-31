using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegNumber = int.Parse(Console.ReadLine());
            double printVol = int.MinValue;
            string printName = null;

            for (int i = 0; i < kegNumber; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(kegRadius, 2) * height;
                
                if(volume > printVol)
                {
                    printVol = volume;
                    printName = kegModel;
                }
            }
            Console.WriteLine($"{printName}");
        }
    }
}
