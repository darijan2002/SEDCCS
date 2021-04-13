using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHomework
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RolesEnum Role { get; set; }
        protected double Salary { get; set; }

        protected Employee()
        {

        }

        protected Employee(string fName, string lName, RolesEnum role, double sal)
        {
            FirstName = fName;
            LastName = lName;
            Role = role;
            Salary = sal;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0} {1} with salary {2}", FirstName, LastName, GetSalary());
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
