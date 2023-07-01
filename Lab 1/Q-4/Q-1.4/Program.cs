using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the employee's salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the tax rate(in decimal form): ");
            double taxRate = Convert.ToDouble(Console.ReadLine());

            double salaryAfterTax =salary * (1-taxRate);

            Console.WriteLine("Salary after tax: " + salaryAfterTax);
             
            Console.ReadLine();
        }
    }
}
