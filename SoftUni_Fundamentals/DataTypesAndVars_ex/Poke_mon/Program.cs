using System;
namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            //N
            int pokePower = int.Parse(Console.ReadLine());
            //M
            int distance = int.Parse(Console.ReadLine());
            //Y
            int exhaustFactor = int.Parse(Console.ReadLine());
            //pokes count
            int pokeCount = 0;
            //calculate 50% of poke power
            double fiftyPercent = pokePower / 2.0;

            while (pokePower >= distance)
            {
                if (pokePower == fiftyPercent && exhaustFactor > 0)
                {
                    pokePower /= exhaustFactor;
                }
                else
                {
                    pokePower -= distance;
                    pokeCount++;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCount);
        }
    }
}