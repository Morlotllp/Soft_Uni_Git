using System;
namespace EqualArr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            bool identical = false;
            int sum = 0;
            int index = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    identical = false;
                    index = i;
                    break;
                }
                else
                {
                    identical = true;
                    sum += int.Parse(arr1[i]);
                }
            }
            if (identical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}