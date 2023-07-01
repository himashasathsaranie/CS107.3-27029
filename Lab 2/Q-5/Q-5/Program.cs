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
            for(int i = 1; i<= 10;i++)
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if(number==0)
                {
                    Console.WriteLine("The number is zero.");
                }
                else if(number%2==0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            Console.ReadLine();
        }
    }
}
