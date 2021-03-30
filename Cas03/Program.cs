using System;

namespace Cas03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"Counter i = {i}");
            }

            //for (; ; ) { } - Infinite loop

            int[] numbers = { 1, 2, 3, 5, 4 };
            Array.Reverse(numbers);
            string[] names = { "John", "Bob", "Jane", "Foo", "Bar" };
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{numbers[i]}, {names[i]}");
            }
            int[] a = null;
            Console.WriteLine(a?.Length);
            Array.Resize(ref a, 40);
            Console.WriteLine(a?.Length);
        }
    }
}
