using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The whole group of G6 loves C#.They find learning this language fun and easy!";
            var dot = str.IndexOf('.');
            dot++;

            string str2 = str.Substring(dot);
            Console.WriteLine(str2);
        }

    }
}
