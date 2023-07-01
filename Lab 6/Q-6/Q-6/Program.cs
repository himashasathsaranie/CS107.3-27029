using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            ArrayOperations arrayOps = new ArrayOperations();
            arrayOps.FillArray(size);

            Console.ReadLine();
        }
    }
}
