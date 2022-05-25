using System;
namespace Login
{
    class Program
    {
        static string passGenerator(string x)
        {
            string a = x;
            char[] b = a.ToCharArray();
            Array.Reverse(b);
            string c = new string(b);

            return (c);
        }

        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            bool end = false;
            string password = passGenerator(name);

            int counter = 0;

            while (end == false)
            {
                string passTry = Console.ReadLine();
                if (counter > 3)
                {
                    Console.WriteLine("User {0} blocked!", name);
                    end = true;
                }
                else if (password == passTry)
                {
                    Console.WriteLine("User {0} logged in.", name);
                    end = true;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                }
            }
        }
    }
}