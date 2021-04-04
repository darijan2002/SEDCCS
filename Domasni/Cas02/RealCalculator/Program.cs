using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the operation: ");
            string oper = Console.ReadLine();

            int sol = 0;
            switch(oper)
            {
                case "+":
                    sol = a + b;
                    break;
                case "-":
                    sol = a - b;
                    break;
                case "*":
                    sol = a * b;
                    break;
                case "/":
                    sol = a / b;
                    break;
            }

            Console.WriteLine("The result is {0}.", sol);
        }
    }
}
