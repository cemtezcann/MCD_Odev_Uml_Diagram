using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Odev_Uml_Diagram
{
    public class HourlyEmployee : Employee
    {
        private double wage;

        private double hours;

        public double Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Wage)} olmali >= 0");
                }
                wage = value;
            }
        }

        public double Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value < 0 || value > 160)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Hours)} olmali >= 0 ve <=160");
                }

                hours = value;
            }
        }

        public HourlyEmployee(string firstName, string lastName, string ssn, double wage, double hours) 
            : base(firstName, lastName, ssn)
        {
            Wage = wage;
            Hours = hours;
        }

        public override double Earnings()
        {
            return Wage * Hours;            
        }

        public override string ToString() => $"Hourly employee: {base.ToString()}\n" + $"Wage: {Wage} \nHours: {Hours}";
        
           
        
    }
}
