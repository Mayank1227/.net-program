using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class AssignmentOperatorExample1
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            num += 2;  //num=num+2    (num += 2; shortend expression)

            Console.WriteLine("display value of num after assignment:" + num);


            num *= 2;
            Console.WriteLine("display value of num after multiply and assignment:" + num);

            Console.ReadKey();

        }
    }
}
