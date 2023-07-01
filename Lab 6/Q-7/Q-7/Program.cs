using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            Console.WriteLine("Enter values for Array1 : ");
            for(int i = 0; i < size; i++)
            {
                Console.Write("Value " + (i + 1) + ":");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nEnter values for Array2 : ");
            for( int i = 0; i < size;i++)
            {
                Console.Write("Value " + (i+1) + ":");
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int scalarSum = CalculateScalarSum(array1,array2);
            int[] vectorSum = CalculateVectorSum(array1,array2);
            int[] vectorProduct = CalculateVectorProduct(array1,array2);
            int scalarProduct = CalculateScalarProduct(array1,array2);

            Console.WriteLine("\nScalar Sum : " + scalarSum);
            Console.WriteLine("Vector Sum : ");
            DisplayArray(vectorSum);
            Console.WriteLine("Vector Product :");
            DisplayArray(vectorProduct);
            Console.WriteLine("Scalar Product :" + scalarProduct);

            Console.ReadLine();

        }
        static int CalculateScalarSum(int[] array1, int[] array2)
        {
            int sum = 0;
            for(int i=0; i<array1.Length; i++)
            { 
                sum += array1[i] + array2[i]; 
            }
            return sum;
        }
        static int[] CalculateVectorSum(int[] array1, int[] array2)
        {
            int[]  sumArray = new int[array1.Length];
            for(int i=0 ; i<array1.Length ; i++)
            {
                sumArray[i] = array1[i] + array2[i];
            }
            return sumArray;
        }
        static int[] CalculateVectorProduct(int[] array1, int[] array2)
        {
            int[] productArray = new int[array1.Length];
            for(int i = 0 ; i<array1.Length ;i++)
            {
                productArray[i] = array1[i] * array2[i];
            }
            return productArray;
        }
        static int CalculateScalarProduct(int[] array1, int[] array2)
        {
            int product = 0;
            for(int i = 0; i<array1.Length ; i++)
            {
                product += array1[i] * array2[i];
            }
            return product;
        }
        static void DisplayArray(int[] array)
        {
            foreach(int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
