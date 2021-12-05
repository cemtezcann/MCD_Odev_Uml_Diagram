using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Odev_Uml_Diagram
{
     public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private double baseSlary;

        public double BaseSalary
        {
            get
            {
                return baseSlary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(BaseSalary)} olmali >=0");
                }
                baseSlary = value;
            }
        }

        public BasePlusCommissionEmployee(string firstName, string lastName, string ssn, double grossSales, 
            double commissionRate, double baseSalary) 
            : base(firstName, lastName, ssn, grossSales, commissionRate)
        {
            BaseSalary = baseSalary;
        }

        public override double Earnings() => BaseSalary + base.Earnings();

        public override string ToString() => $"BaseSalaried: {base.ToString()}\n" + $"Base salary: {BaseSalary}\n"; 


    }
}
