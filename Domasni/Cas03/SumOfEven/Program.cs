using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int sum = 0;
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Enter integer #{i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine($"The sum is {sum}. ");
        }
    }
}
