using System;
namespace VendingMachine
{
    class Program
    {
        static double EnterCoins()
        {
            bool end = false;
            double sum = 0;

            while (end == false)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    end = true;
                }
                else
                {
                    double coins = double.Parse(input);

                    if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                    {
                        Console.WriteLine("Cannot accept {0}", coins);
                    }
                    else
                    {
                        sum += coins;
                    }
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            
            double money = EnterCoins();

            string product = null;
            double prodTotalPrice = 0;
            bool end = false;


            while (end == false)
            {
                product = Console.ReadLine();
                if (product == "End")
                {
                    end = true;
                }
                else if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" && product != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                else
                {
                    //prices
                    double price = 0;
                    switch (product)
                    {
                        case "Nuts":
                            price = 2;
                            break;
                        case "Water":
                            price = 0.7;
                            break;
                        case "Crisps":
                            price = 1.5;
                            break;
                        case "Soda":
                            price = 0.8;
                            break;
                        case "Coke":
                            price = 1;
                            break;
                        default:
                            break;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine("Purchased {0}", product.ToLower());
                        money -= price;
                        prodTotalPrice += price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
            }
            //double change = money - prodTotalPrice;
            Console.WriteLine("Change: {0:f2}",money);
        }
    }
}