using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_5
{
    internal class ArrayOperations
    {
        public void PerformArrayOperations(int[] array)
        {
            int minValue = FindMinimumValue(array);
            int maxValue = FindMaximumValue(array);
            double averageValue = FindAverageValue(array);
            int[] reverseArray = ReverseArray(array);

            Console.WriteLine("Minimum value: " + minValue);
            Console.WriteLine("Maximum value: " + maxValue);
            Console.WriteLine("Average value: " +  averageValue);
            Console.WriteLine("Reversed array: ");

            foreach(int num in reverseArray)
            {
                Console.Write(num + " ");
            }

        }
        private int FindMinimumValue(int[] array)
        {
            int minValue = array[0];

            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }
        private int FindMaximumValue(int[] array)
        {
            int maxValue = array[0];
            for(int i = 1; i < array.Length; ++i)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        private double FindAverageValue(int[] array)
        {
            int sum = 0;

            foreach(int num in array)
            {
                sum += num;
            }
            double average = (double)sum / array.Length;
            return average;
        }
        private int[] ReverseArray(int[] array)
        {
            int[] reverseArray = new int[array.Length];
            for(int i = 0;i < array.Length; ++i)
            {
                reverseArray[i] = array[array.Length - 1 - i];
            }
            return reverseArray;
        }
    }
}
