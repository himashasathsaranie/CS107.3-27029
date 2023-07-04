using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of rhe array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            ArrayClass obj1 = new ArrayClass();
            int[] array = obj1.arrayMethod(size);

            Console.WriteLine("\nDisplay the array: ");
            for(int i=0;i<array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
