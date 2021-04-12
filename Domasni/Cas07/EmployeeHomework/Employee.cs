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

        private Employee()
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
            Console.WriteLine("{0} {1} with salary {2}", FirstName, LastName, Salary);
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
