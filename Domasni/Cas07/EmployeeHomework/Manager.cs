using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHomework
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string fName, string lName, double sal) : base(fName, lName, RolesEnum.Manager, sal) { }
        public void AddBonus(double b)
        {
            Bonus += b;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
