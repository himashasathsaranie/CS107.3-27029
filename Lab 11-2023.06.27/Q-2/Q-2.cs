using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = {122, 23, 45, 67, 89, 234, 567};
            int smallest = num[0];
            int biggest = num[0];
           
            for(int i = 0; i < num.Length; i++)
            {
                if(smallest > num[i])
                { 
                    smallest = num[i];
                }
                if(biggest < num[i])
                { 
                    biggest = num[i]; 
                }
            }
            Console.WriteLine("Smallest : " + smallest);
            Console.WriteLine("Biggest : " + biggest);
            Console.ReadKey();
        }
    }
}
