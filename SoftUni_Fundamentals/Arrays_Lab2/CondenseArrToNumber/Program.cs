using System;
using System.Linq;
namespace CondensedNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elements = myArray.Length;
            
            while (elements > 1)
            {
                int sum = 0;
                
                int[] condensed = new int[elements - 1];

                for (int i = 1; i < elements; i++)
                {
                    sum = myArray[i] + myArray[i - 1];
                    condensed[i - 1] = sum;
                }
                elements--;
                myArray = condensed;
            }
            foreach (int item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}