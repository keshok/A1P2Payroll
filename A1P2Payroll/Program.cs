using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1P2Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int sinNumber;
            double payRate;
            double hoursWorked;
            double grossPay;
            double federalTax;
            double provincialTax;
            double netPay;
            double GST = 0.15d;
            double PST = 0.055d;

            firstName = "Keshok";
            lastName = "Sivalingam";
            sinNumber = 123456789;
            payRate = 35.75d;
            hoursWorked = 7.50d;

            grossPay = payRate * hoursWorked;
            federalTax = GST * grossPay;
            provincialTax = PST * grossPay;
            netPay = grossPay - federalTax - provincialTax;

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Payroll summary for: {0} {1}", firstName, lastName);
            Console.WriteLine("SIN: {0}", sinNumber);
            Console.WriteLine("You worked {0:F} hours at {1:C} per hour.", hoursWorked, payRate);
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Gross pay: {0, 10}{1:C}", "",grossPay);
            Console.WriteLine("Federal tax: {0, 9}{1:C}", "",federalTax);
            Console.WriteLine("Provincial tax: {0, 6}{1:C}", "",provincialTax);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Net pay: {0, 12}{1:C}", "",netPay);
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Press any key to continue or exit...");
            Console.ReadKey();
        }
    }
}
