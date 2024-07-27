using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class Unbboxing
    {
        static void Main(string[] args)
        {
            int num = 235;//Value type

            object obj = num; //boxing

            int res = (int)obj; //unboxing process


            Console.WriteLine("Display value of num:" + num);
            Console.WriteLine("Display value of num:" + res);

            Console.ReadKey();

        }
    }
}
