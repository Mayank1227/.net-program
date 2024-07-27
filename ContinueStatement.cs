using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class ContinueStatement
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                if (i == 7 || i == 13 )
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
