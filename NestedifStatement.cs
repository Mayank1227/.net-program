using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class NestedifStatement
    {
        static void Main(string[] args)
        {
            //WAP to find the largest 

            int a, b, c;

            Console.WriteLine("Enter the value of a b and c");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("A is greater");
                }
                else
                {
                    Console.WriteLine("C is greater");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b is greater");
                }
                else
                {
                    Console.WriteLine("C is greater");
                }

            }

            Console.ReadKey();

        }
    }
}
