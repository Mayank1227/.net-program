using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class Tableofgivennousingwhileloopcs
    {
        static void Main(string[] args)
        {
            int num = 5;
            int i = 1;

            while (i <= 10)
            {
                // Console.WriteLine(num, i, num * i);
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);

                i++;
            }
            Console.ReadKey();
        }
    }
}
