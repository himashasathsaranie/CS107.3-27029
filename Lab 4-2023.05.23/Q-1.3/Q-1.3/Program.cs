using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the kilometer value: ");
            double kilometer = Convert.ToDouble(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            double meter = converter.KilometerToMeter(kilometer);

            Console.WriteLine("The equivalent meter value is: "+meter);

            Console.ReadLine();
        }
    }
}
