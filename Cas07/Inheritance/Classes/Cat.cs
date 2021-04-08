using Inheritance.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Classes
{
    public class Cat : Animal
    {
        public string Laziness{ get; set; }

        public Cat() : base(AnimalTypes.Cat)
        {
            Console.WriteLine("Cat was created");
        }

        public void Meow()
        {
            Console.WriteLine("Meow, meow!");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("The cat is eating fish");
        }
    }
}
