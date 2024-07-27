using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class NestedForPatternProgram
    {
        static void Main(string[] args)
        {
            int r, c, n;

            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (r = 1; r <= n; r++)
            {
                for (c = 1; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine();

            }

            Console.ReadKey();


        }
    }
}
