using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class UnaryOperatorsIncreDecExample
    {
        static void Main(string[] args)
        {
            int i = 20, r;
            int j = 60, s;


            r = i++; //increment by 1 (++i (pre incrment)(i++ post increment)
            //r=++i first increase the value and then assign
            //r=i++ first assign the value and then increase

            s = --j; //decrment by 1

            Console.WriteLine("After incrment value of i:" + r);

            Console.WriteLine("After decrement value of j:" + s);

            Console.ReadKey();
        }
    }
}
