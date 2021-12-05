using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Odev_Uml_Diagram
{
     public class SalariedEmployee : Employee
    {
        private double weeklySalary;

        public double WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(WeeklySalary)} olmali >= 0 ");
                }
                weeklySalary = value;
            }
        }

        public SalariedEmployee (string firstName, string lastName, string ssn, double weeklySalary) 
            : base(firstName, lastName, ssn)
        {
            WeeklySalary = weeklySalary;
        }
        public override double Earnings() => WeeklySalary;

        public override string ToString() => $"Salaried employee: {base.ToString()}\n" + $"Weekly salary: {WeeklySalary}";
        
            
        


    }
}
