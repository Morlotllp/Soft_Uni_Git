using System;

namespace TheatrePromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            switch (dayType)
            {
                case "Weekday":
                    if (age <= 18 && age >= 0)
                    {
                        price = 12;
                        Console.WriteLine("{0}$", price);
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 18;
                        Console.WriteLine("{0}$", price);
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 12;
                        Console.WriteLine("{0}$", price);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (age <= 18 && age >= 0)
                    {
                        price = 15;
                        Console.WriteLine("{0}$", price);
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20;
                        Console.WriteLine("{0}$", price);
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 15;
                        Console.WriteLine("{0}$", price);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    if (age <= 18 && age >= 0)
                    {
                        price = 5;
                        Console.WriteLine("{0}$", price);
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                        Console.WriteLine("{0}$", price);
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 10;
                        Console.WriteLine("{0}$", price);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                default:
                    break;
            }   
            
        }
    }
}