using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    internal class FindValues
    {
        public double FindArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
        public double FindCircimference(double radius)
        {
            double circumference = 2 *Math.PI * radius;
            return circumference;
        }
    }
}
