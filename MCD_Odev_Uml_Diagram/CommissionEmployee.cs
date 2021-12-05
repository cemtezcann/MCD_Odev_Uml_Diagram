using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Odev_Uml_Diagram
{
    public class CommissionEmployee : Employee
    {
        private double grossSales;

        private double commissionRate;

        public double GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GrossSales)} olmali >=0 ");
                }
                grossSales = value;
            }

        }
        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value < 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(CommissionRate)} olmali >=0 ve <1)");
                }

                commissionRate = value;
            }
        }

        public CommissionEmployee(string firstName, string lastName, string ssn, double grossSales, double commissionRate) 
            : base(firstName, lastName, ssn)
        {
           GrossSales = grossSales;
           CommissionRate = commissionRate;

        }

        public override double Earnings() => CommissionRate * GrossSales;

        public override string ToString() => $"Commission employee: {base.ToString()}\n" + $"Gross sales: {GrossSales}\n" + $"Commission rate: {CommissionRate}";
    }
}