using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x  = { "first", "second", "third", "fourth" };

            float avg = 0;
            for(int i = 0; i < 4; i++)
            {
                Console.Write($"Enter the {x[i]} number: ");
                avg += float.Parse(Console.ReadLine());
            }

            avg /= 4;
            Console.WriteLine("The average is {0:f2}.", avg);
        }
    }
}
