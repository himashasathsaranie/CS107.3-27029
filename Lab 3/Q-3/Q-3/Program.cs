using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = CalculateDigitSum(number);

            Console.WriteLine("Sum of the digits: " + sum);

            Console.ReadLine();
        }
        static int CalculateDigitSum(int number)
        {
            int sum = 0;
            

            while(number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }
    }
}
