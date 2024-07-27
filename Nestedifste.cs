using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class Nestedifste
    {
        static void Main(string[] args)
        {
            //WAP to find the largest 

            int a, b, c, d;

            Console.WriteLine("Enter the value of a b c and d");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                    {
                        Console.WriteLine("A is the greatest");
                    }
                    else
                    {
                        Console.WriteLine("D is the greatest");
                    }
                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("C is the greatest");
                    }
                    else
                    {
                        Console.WriteLine("D is the greatest");
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        Console.WriteLine("B is the greatest");
                    }
                    else
                    {
                        Console.WriteLine("D is the greatest");
                    }
                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("C is the greatest");
                    }
                    else
                    {
                        Console.WriteLine("D is the greatest");
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
