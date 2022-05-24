using System;
namespace StrongNum
{
    class Program
    {
        static int Fact(int x)
        {
            int num = x;
            int factoriel = 1;

            for (int i = 1; i <= num; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string numStr = Convert.ToString(num);
            int sum = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                sum += Fact(Convert.ToInt32(numStr[i].ToString()));
            }

            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}