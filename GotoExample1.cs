using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class GotoExample1
    {
        static void Main(string[] args)
        {
            int num, i = 1;
            Console.Write("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());

        START:  //lable name
            Console.WriteLine("{0}*{1}={2}", num, i, num * i);
            i++;
            if (i <= 10)
                goto START;
            Console.ReadKey();
        }
    }
}
