
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class Addition
    {
        static void Main(string[] args)
        {
            int a = 100, b = 208, c; //Variable declaration and Initialization
            c = a + b;  //Addition Expression

            //    Console.WriteLine("Addition of a and b:" + c);

            Console.WriteLine("Addition of {0} and {1}={2}", a, b, c);
            Console.ReadKey();
        }
    }
}
