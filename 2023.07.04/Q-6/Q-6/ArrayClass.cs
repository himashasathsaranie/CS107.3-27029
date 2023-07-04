using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_6
{
    public class ArrayClass
    {
        public int[] arrayMethod(int size)
        {
            int[] array = new int[size];
            for(int i=0; i<array.Length; i+=2)
            {
                Console.WriteLine("Enter a value: ");
                int value = Convert.ToInt32(Console.ReadLine());

                array[i] = value;
                array[i + 1] = 0;
            }
            return array;
        }
    }
}
