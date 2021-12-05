using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Odev_Uml_Diagram
{
    public abstract class Employee
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string SSN { get; set; }

        public Employee (string firstName, string lastName, string ssn )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SSN = ssn;
        }

        public abstract double Earnings();

        public override string ToString() => $"{FirstName} {LastName} \n" + $"SSN: {SSN}";
    }
}
