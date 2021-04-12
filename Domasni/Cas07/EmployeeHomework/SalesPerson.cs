using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHomework
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesPerson(string fName, string lName) : base(fName, lName, RolesEnum.Sales, 500)
        {
            
        }

        public void AddSuccessRevenue(double profit)
        {
            SuccessSaleRevenue = profit;
        }

        public override double GetSalary()
        {
            return Salary + (
                SuccessSaleRevenue <= 2000 ? 500 :
                SuccessSaleRevenue <= 5000 ? 1000 : 1500
                );
        }
    }
}
