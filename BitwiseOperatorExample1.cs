using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class BitwiseOperatorExample1
    {
        static void Main(string[] args)
        {
            int n1 = 5, n2 = 10, res;

            res = n1 & n2;

            Console.WriteLine("display result of n1&n2: " + res);

            res = n1 | n2;

            Console.WriteLine("display result of n1|n2: " + res);

            Console.ReadKey();
        }
    }
}
