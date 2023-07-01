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
            Console.Write("Enter the kilometer value: ");
            double kilometer = Convert.ToDouble(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            converter.KilometerToMeter(kilometer);

            Console.ReadLine();
        }
    }
}
