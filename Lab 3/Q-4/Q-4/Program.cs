using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = CalculateOddSum(n);

            Console.WriteLine("Sum of odd numbers: " + sum);

            Console.ReadLine();
        }
        static int CalculateOddSum(int n)
        {
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
