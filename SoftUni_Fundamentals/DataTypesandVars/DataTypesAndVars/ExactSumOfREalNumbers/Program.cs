using System;
namespace SumRealNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < numCount; i++)
            {
                decimal n = decimal.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}