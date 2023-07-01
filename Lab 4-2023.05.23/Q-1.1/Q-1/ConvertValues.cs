using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1
{
    internal class ConvertValues
    {
        public void KilometerToMeter()
        {
            Console.Write("Enter the kilometer value: ");
            double kilometer = Convert.ToDouble(Console.ReadLine());
            double meter = kilometer * 1000;
            Console.WriteLine("The equivalent meter value is: "+ meter);
        }
    }
}
