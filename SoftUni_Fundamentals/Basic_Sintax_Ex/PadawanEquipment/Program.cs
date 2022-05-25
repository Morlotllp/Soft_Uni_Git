using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            //prices
            double saberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());


            double sabersNeeded = studentsCount + studentsCount * 0.1;

            int beltCount = 0;

            for (int i = 1; i <= studentsCount; i++)
            {
                if (i % 6 == 0)
                {
                    beltCount--;
                }
                beltCount++;
            }

            double totalPrice = Math.Ceiling(sabersNeeded) * saberPrice + robesPrice * studentsCount + beltCount * beltPrice;

            if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - money:f2}lv more.");
            }
        }
    }
}
