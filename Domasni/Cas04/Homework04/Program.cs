using System;

namespace Homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            FunWithStrings(str);

            string fixedString = FixString(str);
            Console.WriteLine(fixedString);
        }

        static string FixString(string str)
        {
            str = str.Trim();

            while(str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }

            return str;
        }

        static void FunWithStrings(string str)
        {
            str = str.Trim();
            // reverse
            var chars = str.ToCharArray();
            {
                Array.Reverse(chars);
                Console.WriteLine($"Reversed: {new string(chars)}");
            }

            // number of vowels
            {
                int count = 0;
                string vowels = "aeiou";
                chars = str.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    count += vowels.Contains(char.ToLower(chars[i])) ? 1 : 0;
                }
                Console.WriteLine($"The string contains {count} vowels.");
            }

            // palindrome
            {
                chars = str.ToCharArray();
                bool palindrome = true;
                for(int i = 0; i < chars.Length/2; i++)
                {
                    if(chars[i] != chars[chars.Length-i-1])
                    {
                        palindrome = false;
                        break;
                    }
                }

                Console.WriteLine(@"The string is {0}a palindrome.", palindrome ? "" : "not ");
            }

            string[] words = str.Split(' ');
            Array.Sort(words, (string a, string b) => b.Length - a.Length);
            Console.WriteLine($"Longest word: {words[0]}.");
            Console.WriteLine($"Shortest word: {words[words.Length-1]}.");
            Console.WriteLine($"Number of words: {words.Length}.");

            Array.Sort(chars);
            char prevchar = chars[0];
            char mostUsed = prevchar;
            int cnt = 1, maxcnt = 1;
            for(int i = 1; i < chars.Length; i++)
            {
                if(prevchar != chars[i])
                {
                    if(maxcnt < cnt && prevchar != ' ')
                    {
                        maxcnt = cnt;
                        mostUsed = prevchar;
                    }
                    cnt = 1;
                    prevchar = chars[i];
                }
                else
                {
                    cnt++;
                }
            }
            if (maxcnt < cnt && prevchar != ' ')
            {
                maxcnt = cnt;
                mostUsed = prevchar;
            }
            Console.WriteLine($"The most frequent character is {mostUsed} with {maxcnt} occurences.");
        }
    }
}
