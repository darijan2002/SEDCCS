using Inheritance.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Classes
{
    public class Animal
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public AnimalTypes Type { get; set; }

        public Animal()
        {
            Console.WriteLine("A new instance of class 'Animal' was created");
        }

        public Animal(AnimalTypes animalType)
        {
            Type = animalType;
        }

        public Animal(string name, AnimalTypes type)
        {
            Name = name;
            Type = type;
        }

        public void PrintInfo()
        {
            Console.WriteLine("ID: {0}, Name: {1}, Animal: {2}", Id, Name, Type);
        }
        
        public virtual void Eat()
        {
            Console.WriteLine("The {0} named {1} is now eating!", Type, Name);
        }

    }
}
