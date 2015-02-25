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

            federalTax = 0.15;
            provincialTax = 0.055;
            firstName = Convert.ToString("Keshok");
            lastName = Convert.ToString("Sivalingam");
            sinNumber = 123456789;
            payRate = 35.75;
            hoursWorked = 7.5;


            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Press any key to continue or exit...");
            Console.ReadKey();
        }
    }
}
