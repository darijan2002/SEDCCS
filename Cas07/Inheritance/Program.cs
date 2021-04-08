using System;
using Inheritance.Classes;
using Inheritance.Enums;
using OurClasses;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog jango = new Dog()
            {
                Id = 1,
                Name = "Jango",
                //Type = "Dog",
                Race = "Poodle"
            };

            jango.PrintInfo();
            jango.Eat();

            jango.Bark();

            Console.WriteLine();

            Animal dambo = new Animal()
            {
                Id = 2,
                Name = "Dambo",
                Type = AnimalTypes.Other
            };

            dambo.PrintInfo();
            dambo.Eat();

            Console.WriteLine();

            Cat kitty = new Cat()
            {
                Id = 3,
                Name = "Kitty",
                //Type = "Cat",
                Laziness = "Very lazy"
            };

            kitty.PrintInfo();
            kitty.Meow();
            kitty.Eat();

            Console.WriteLine();

            WeekDays tuesday = WeekDays.Tuesday;
            Console.WriteLine(tuesday);
            Console.WriteLine(tuesday.ToString() == "Tuesday");
            Console.WriteLine(tuesday == (WeekDays)2);

            Console.WriteLine();

            Mouse mouse = new Mouse();
        }
    }
}
