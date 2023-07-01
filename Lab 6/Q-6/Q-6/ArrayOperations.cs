using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_6
{
    internal class ArrayOperations
    {
        public void FillArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter value for index " + i + ": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                array[++i] = 0;
            }
            Console.WriteLine("Values in the array: ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}
