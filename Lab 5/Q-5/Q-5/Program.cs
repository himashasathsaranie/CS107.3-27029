using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("Enter 10 numbers: ");

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            ArrayOperations arrayOps = new ArrayOperations();
            arrayOps.PerformArrayOperations(array);

            Console.ReadLine();
        }
    }
}
