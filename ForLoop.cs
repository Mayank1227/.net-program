using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            //WAP to print the numbers between 1 to 100 that divisible by 3 or
            //5 
            int i;
            for (i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)

                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey();
        }
    }
}
