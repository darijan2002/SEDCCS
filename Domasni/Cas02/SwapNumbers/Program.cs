using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine("\nAfter swapping");
            Console.WriteLine($"First number: {a}");
            Console.WriteLine($"Second number: {b}");
        }
    }
}
