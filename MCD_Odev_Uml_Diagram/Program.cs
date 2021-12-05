using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Odev_Uml_Diagram
{
        public class Program
        {
        static void Main(string[] args)
        {
            var salariedEmployee = new SalariedEmployee("Dolapdereli", "Sabri", "23568964", 56000.00D);
            
            var hourlyEmployee =   new HourlyEmployee("Vagon", "Necmi", "12345670", 836400.00D , 50.0D);

            var commissionEmployee = new CommissionEmployee("Dolap", "Osman","24242342", 82700.00D, .05D);
           
            var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Komidin", "Bahattin", "98463728", 54000.00D, .07D , 17800.00D);

            Console.WriteLine($"{salariedEmployee}\nEarned: " + $"{salariedEmployee.Earnings()}\n");

            Console.WriteLine($"{hourlyEmployee}\nEarned: {hourlyEmployee.Earnings()}\n");

            Console.WriteLine($"{commissionEmployee}\nEarned: {commissionEmployee.Earnings()}\n");

            Console.WriteLine($"{basePlusCommissionEmployee}\nEarned: {basePlusCommissionEmployee.Earnings()}\n");

            var employees = new List<Employee>() { salariedEmployee, hourlyEmployee, commissionEmployee, basePlusCommissionEmployee };

            foreach (var currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee);

                if(currentEmployee is BasePlusCommissionEmployee)
                {
                    var employee = (BasePlusCommissionEmployee) currentEmployee;

                    employee.BaseSalary *= 1.25D;

                    Console.WriteLine("New base salary with %25 increase is: " + $"{employee.BaseSalary}");
                }
                Console.WriteLine($"earned: {currentEmployee.Earnings()}\n");
            }
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"Employee {i} is a {employees[i].GetType()}");
            }

            Console.ReadKey();
        }
    }
}
