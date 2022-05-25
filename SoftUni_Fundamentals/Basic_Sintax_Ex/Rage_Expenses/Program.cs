using System;
namespace Rage_Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int keyboardSmashes = 0;

            double rageExpenses = 0;

            for (int i = 1; i <= gamesLost; i++)
            {
                //Every second lost game
                if (i % 2 == 0)
                {
                    //headset
                    rageExpenses += headsetPrice;
                }
                //Every third lost game
                if (i % 3 == 0)
                {
                    //mouse
                    rageExpenses += mousePrice;
                }
                //When Petar trashes both his mouse and headset in the same lost game
                if (i % 3 == 0 && i % 2 == 0)
                {
                    //keyboard
                    rageExpenses += keyboardPrice;
                    keyboardSmashes++;

                    //Every second time, when he trashes his keyboard
                    if (keyboardSmashes % 2 == 0 && keyboardSmashes != 0)
                    {
                        //display
                        rageExpenses += displayPrice;
                    }
                }
            }
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}