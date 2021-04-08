using Inheritance.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Classes
{
    public class Dog : Animal
    {

        public string Race { get; set; }

        public Dog() : base(AnimalTypes.Dog)
        {
            Console.WriteLine("A new instance of class 'Dog' was created");
        }

        public void Bark()
        {
            Console.WriteLine("Bark, bark!");
        }

    }
}
