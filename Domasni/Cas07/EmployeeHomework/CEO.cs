using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHomework
{
    public class CEO : Employee
    {
        public CEO(string fName, string lName, double sal) : base(fName, lName, RolesEnum.CEO, sal)
        {
        }

        public Employee[] Employees { get; set; }
        public int Shares { get; set;}
        private double SharesPrice { get; set; }

        public void AddSharesPrice(double p)
        {
            SharesPrice += p;
        }

        public void PrintEmployees()
        {
            foreach(var e in Employees)
            {
                e.PrintInfo();
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
    }
}
