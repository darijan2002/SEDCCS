using System;

namespace Homework05
{
    class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }
    }
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }
        public int CalculateSpeed()
        {
            if(Driver != null)
            return Driver.Skill * Speed;
            else
            {
                Console.WriteLine($"Car {Model} has no driver");
                return 0;
            }
        }
    }


    class Program
    {
    static void RaceCars(Car a, Car b)
    {
            int delta = a.CalculateSpeed() - b.CalculateSpeed();
            if(delta > 0)
            {
                Console.WriteLine($"The car 1, model {a.Model} with speed {a.Speed}, driven by {a.Driver.Name} wins!");
            } else if(delta < 0)
            {
                Console.WriteLine($"The car 2, model {a.Model} with speed {a.Speed}, driven by {a.Driver.Name} wins!");
            } else
            {
                Console.WriteLine("The race was a draw!");
            }
    }
        static void Main(string[] args)
        {
            Car[] cars =
            {
                new Car(){Model = "Hyundai", Speed = 170},
                new Car(){Model = "Mazda", Speed = 185},
                new Car(){Model = "Ferrari", Speed = 210},
                new Car(){Model = "Porsche", Speed = 210}
            };
            Driver[] drivers =
            {
                new Driver(){Name = "Bob", Skill = 5},
                new Driver(){Name = "Greg", Skill = 2},
                new Driver(){Name = "Jill", Skill = 3},
                new Driver(){Name = "Anne", Skill = 5}
            };

            while(true)
            {
                Car car1, car2;
                int choice;

                // choose car1 and driver 1
                Console.WriteLine("Choose car number one: ");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1}. {cars[i].Model} with speed {cars[i].Speed} km/h");
                }
                choice = int.Parse(Console.ReadLine()) - 1;
                car1 = new Car() { Model = cars[choice].Model, Speed = cars[choice].Speed };

                Console.WriteLine("Choose driver number one: ");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1}. {drivers[i].Name} with skill {drivers[i].Skill}");
                }
                choice = int.Parse(Console.ReadLine()) - 1;
                car1.Driver = drivers[choice];

                // choose car2 and driver2
                Console.WriteLine("Choose car number two: ");
                for (int i = 0; i < 4; i++)
                {
                    if (cars[i].Model == car1.Model) continue;
                    Console.WriteLine($"{i + 1}. {cars[i].Model} with speed {cars[i].Speed} km/h");
                }
                choice = int.Parse(Console.ReadLine()) - 1;
                car2 = new Car() { Model = cars[choice].Model, Speed = cars[choice].Speed };

                Console.WriteLine("Choose driver number two: ");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1}. {drivers[i].Name} with skill {drivers[i].Skill}");
                }
                choice = int.Parse(Console.ReadLine()) - 1;
                car2.Driver = drivers[choice];

                RaceCars(car1, car2);

                Console.WriteLine("If you wish to stop racing, type 'stop', else type anything else.");
                if (Console.ReadLine().ToLower() == "stop") break;
            }
        }
    }
}
