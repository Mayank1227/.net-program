using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class OutParameterExample1
    {
        static void Main(string[] args)
        {
            int x, y;
            Multiplication(out x, out y);
            Console.WriteLine("x Value:{0}", x);
            Console.WriteLine("y Value:{0}", y);
            Console.ReadKey();

        }
        public static void Multiplication(out int a, out int b)
        {
            Console.WriteLine("Enter the value of a and b:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            //  a = 10;
            //  b = 5;

            a *= a; //a=a*a;

            b *= b;
        }
        }
}
