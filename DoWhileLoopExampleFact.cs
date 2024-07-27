using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class DoWhileLoopExampleFact
    {
        static void Main(string[] args)
        {
            //factorial of given no-------> 5 (1*2*3*4*5)
            int i = 1, num, f = 1;
            Console.WriteLine("Enter the number for facctoril:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("factorial of given no");
            do
            {
                f = f * i;
                i++;
            } while (i <= num);
            Console.Write("factorial of given no: " + f);
            //WAP to print the fibonacci series using do.........while loop

            //0 1 1 2 3 5
            Console.ReadKey();

        }
    }
}
