using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHomework
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string fName, string lName, double sal) : base(fName, lName, RolesEnum.Contractor, sal) { }

        public override double GetSalary()
        {
            return Salary = WorkHours * PayPerHour;
        }

        public string CurrentPosition()
        {
            // ne znam sto se bara tuka
            return "Department";
        }
    }
}
