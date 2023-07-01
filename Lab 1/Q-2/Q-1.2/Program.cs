using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = CalculateCircleArea(radius);

            Console.WriteLine("The area of the circle is: " + area);

            Console.ReadLine();
        }
        static double CalculateCircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
