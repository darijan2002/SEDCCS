using System;

namespace Cas04
{
    class Program
    {
        static int Sum(int a, int b)
        {
            return a+b;
        }

        static int Subtract(int a, int b)
        {
            return a-b;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter an operation (-,+): ");
            //string oper = Console.ReadLine();

            //Console.WriteLine("Please enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //switch(oper)
            //{
            //    case "+":
            //        Console.Write($"{num1} {oper} {num2} = ");
            //        Console.WriteLine(Sum(num1, num2));
            //        break;
            //    case "-":
            //        Console.Write($"{num1} {oper} {num2} = ");
            //        Console.WriteLine(Subtract(num1, num2));
            //        break;
            //    default:
            //        Console.WriteLine("You entered an incorrect operation!");
            //        break;
            //}

            StringOperations();
        }

        static void StringOperations()
        {
            string fullName = "Jane Doe";
            string age = "32";

            Console.WriteLine("STRING.FORMAT 1");
            string userInfoFormat = string.Format("{0} is female and she is {1} years old", fullName, age);
            Console.WriteLine(userInfoFormat);
            Console.WriteLine();

            Console.WriteLine("INTERPOLATION");
            string userInfoInterpolated = $"{fullName} is female and she is {age} years old";
            Console.WriteLine(userInfoInterpolated);
            Console.WriteLine();

            Console.WriteLine("INTERPOLATION");
            string str = string.Format("%s is female and she is %d years old", fullName, age);
            Console.WriteLine(userInfoInterpolated);
            Console.WriteLine();
        }
    }
}
