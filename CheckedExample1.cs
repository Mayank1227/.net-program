using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class CheckedExample1
    {
        static void Main(string[] args)
        {
            //checked
            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);

            }


       

            Console.ReadKey();
        }

    }
}
