using System;
namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //main input
            int ordersCount = int.Parse(Console.ReadLine());

            int caupsulesCount = 0;

            double coffeePrice = 0;
            double totalPrice = 0;

            for (int i = 0; i < ordersCount; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                caupsulesCount = int.Parse(Console.ReadLine());

                coffeePrice = (days * caupsulesCount) * capsulePrice;
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
                totalPrice += coffeePrice;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}