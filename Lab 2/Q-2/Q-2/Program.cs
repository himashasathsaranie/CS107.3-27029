using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enteer the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;
            double substraction = number1 - number2;
            double multiplication = number1 * number2;
            double division = number1 / number2;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Subtraction: " + substraction);
            Console.WriteLine("Multiplication: " + multiplication);
            Console.WriteLine("Division: " +  division);

            Console.ReadLine();

        }
    }
}
