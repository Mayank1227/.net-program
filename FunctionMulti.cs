using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class FunctionMulti
    {
        public void multiplication(int a, int b,int c)
        {
           int D;
           D = a * b * c;
            Console.Write("Multiplication:" + D);
        }
        static void Main(string[] args)
        {
            FunctionMulti obj = new FunctionMulti();
            obj.multiplication(23, 4, 50);
            Console.ReadKey();

        }
        }
}
