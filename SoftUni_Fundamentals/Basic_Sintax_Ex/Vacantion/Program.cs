using System;
namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            //init vars
            int countPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double discount = 0;
            double totalPrice1 = 0;

            //basic price calculation
            switch (day)
            {
                case "Friday":
                    if (groupType == "Students")
                    {
                        price = 8.45;
                    }
                    else if (groupType == "Business")
                    {
                        price = 10.90;
                    }
                    else if (groupType == "Regular")
                    {
                        price = 15;
                    }
                    break;
                case "Saturday":
                    if (groupType == "Students")
                    {
                        price = 9.8;
                    }
                    else if (groupType == "Business")
                    {
                        price = 15.6;
                    }
                    else if (groupType == "Regular")
                    {
                        price = 20;
                    }

                    break;
                case "Sunday":
                    if (groupType == "Students")
                    {
                        price = 10.46;
                    }
                    else if (groupType == "Business")
                    {
                        price = 16;
                    }
                    else if (groupType == "Regular")
                    {
                        price = 22.5;
                    }
                    break;
                default:
                    break;
            }

            //calculate total before discounts
            totalPrice1 = countPeople * price;

            //discount
            if (groupType == "Students" && countPeople >= 30)
            {
                discount = totalPrice1 * 0.15;
            }
            else if (groupType == "Business" && countPeople >= 100)
            {
                discount = 10 * price;
            }
            else if (groupType == "Regular" && (countPeople >= 10 && countPeople <= 20))
            {
                discount = totalPrice1 * 0.05;
            }

            //calculate total
            double totalPrice = totalPrice1 - discount;
            Console.WriteLine("Total price: {0:f2}", totalPrice);
        }
    }
}