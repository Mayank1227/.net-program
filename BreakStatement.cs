using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class BreakStatement
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                if (i == 7 )
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
