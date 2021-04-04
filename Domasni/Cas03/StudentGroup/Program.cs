using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1, studentsG2;
            studentsG1 = new string[] { "Nick", "Jerald", "Helena", "Kathy", "Logan"};
            studentsG2 = new string[] { "Jere", "Devon", "Tania", "Norman", "Monroe" };

            Console.WriteLine("Enter student group (1,2): ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Students in G1: ");
                    for (int i = 0; i < 5; i++) Console.WriteLine(studentsG1[i]);
                    break;
                case 2:
                    Console.WriteLine("Students in G2: ");
                    for (int i = 0; i < 5; i++) Console.WriteLine(studentsG2[i]);
                    break;
                default:
                    Console.WriteLine("Entered incorrect number!");
                    break;
            }
        }
    }
}
