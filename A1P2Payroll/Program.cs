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
            double GST = 0.15;
            double PST = 0.055;

            firstName = Convert.ToString("Keshok");
            lastName = Convert.ToString("Sivalingam");
            sinNumber = 123456789;
            payRate = 35.75;
            hoursWorked = 7.5;

            grossPay = payRate * hoursWorked;
            federalTax = GST * grossPay;
            provincialTax = PST * grossPay;
            netPay = grossPay - federalTax - provincialTax;

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Press any key to continue or exit...");
            Console.ReadKey();
        }
    }
}
