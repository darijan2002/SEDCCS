using System;
using System.Globalization;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                while (true)
                    if (double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double d))
                    { NumberStats(d); break; }
                    else Console.WriteLine("Invalid number!");
                Console.WriteLine("Enter another number? Y/X: ");
                string choice = Console.ReadLine();
                if (choice != "Y") break;
            }
        }

        static void NumberStats(double n)
        {
            Console.WriteLine("Stats for number: {0}", n);
            Console.WriteLine(n > 0 ? "Positive" : "Negative");
            Console.WriteLine("{0}", Math.Floor(n));
            if(Math.Floor(n) < n)
            {
                Console.WriteLine("Decimal");
                Console.WriteLine("Neither even nor odd");
            } else
            {
                int nn = Convert.ToInt32(n);
                Console.WriteLine("Integer");
                Console.WriteLine(nn % 2 == 0 ? "Even" : "Odd");
            }
        }
    }
}
