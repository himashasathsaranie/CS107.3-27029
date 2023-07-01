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
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues calculator = new FindValues();
            double area = calculator.FindArea(radius);
            double circumference = calculator.FindCircimference(radius);

            Console.WriteLine("The area of the circle is : " + area);
            Console.WriteLine("The circumference of the circle is : "+ circumference);

            Console.ReadLine();
        }
    }
}
