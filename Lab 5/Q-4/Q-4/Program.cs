using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeparateClass sparateObj = new SeparateClass();
            separateObj.SayHello();  //ERROR
            /*In this code the, 'SayHello()' method in the 'SeparateClass is declared as 'private'.A 'private' member can
             * only be accessed within the same class where it is defined.To access the 'SayHello()' method from the main 
             * class,it needs to be declared as 'public'. */

            Console.ReadLine();
        }
    }
}
