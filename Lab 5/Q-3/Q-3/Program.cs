using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an operation: ");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");

            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            CalculateValues calculator = new CalculateValues();
            double result = 0;

            switch(choice)
            {
                case 1:
                    result = calculator.Addition(num1,num2);
                    Console.WriteLine("The result of addition is: "+result);
                    break;
                case 2:
                    result = calculator.Subtraction(num1, num2);
                    Console.WriteLine("The result of sutraction is: " + result);
                    break;
                case 3:
                    result = calculator.Multiplication(num1, num2);
                    Console.WriteLine("The result of multiplication is: " + result);
                    break;
                case 4:
                    result = calculator.Division(num1, num2);
                    Console.WriteLine("The result of division is: " + result);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
            Console.ReadLine();
        }
    }
}
