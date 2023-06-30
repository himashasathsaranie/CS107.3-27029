using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 122, 23, 45, 67, 89, 234, 567 };
            int temp;

            for(int i=0; i<num.Length-1; i++)
            {
                for(int j=i+1;j<num.Length;j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }

                }
            }
            Console.WriteLine("Array sorted in ascending order:");

            for(int i=0 ; i<num.Length ; i++)
            {
                Console.Write(num[i]+" ");
            }
            Console.WriteLine();

            for(int i=0;i<num.Length - 1 ; i++)
            {
                for(int j=i+1; j<num.Length; j++)
                {
                    if (num[i] < num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sorted in descending order:");
            for(int i=0;i < num.Length - 1 ; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
