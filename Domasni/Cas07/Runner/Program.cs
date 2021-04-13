using System;
using EmployeeHomework;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make an array called Company with 2 contractors, 2 managers and 1 salesPerson
            // stvarno ne razbiram zosto bi trebalo ova

            Console.WriteLine("Hello World!");
            CEO ceo = new CEO("John", "Doe", 50000);
            // vezbata ne raboti zosto site instanci stanuvaat od tip Employee
            // taka sto se gubi overrideot specificen za sekoj Type i se koristi najopstoto GetSalary
            // stv ne znam kako bi bilo ova
            ceo.Employees = new Employee[]
            {
                new Contractor("C1", "C1", 2000) {
                    WorkHours = 8,
                    PayPerHour = 500
                },
                new Contractor("C2", "C2", 2200),
                new Func<Manager>(() => {
                    Manager man = new Manager("M1", "M1", 1300);
                    man.AddBonus(56);
                    return man;
                })(),
                new Manager("M2", "M2", 1200),
                new SalesPerson("SP1", "SP1")
            };

            ceo.PrintInfo();
            ceo.PrintEmployees();
            Console.WriteLine(ceo.GetSalary());

        }
    }
}
