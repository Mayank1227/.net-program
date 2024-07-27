using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class BoxingExample
    {
        static void Main(string[] args)
        {
            int num = 23;//Value type

            object obj = num; //boxing

            Console.WriteLine("Display value of num:" + num);

            Console.WriteLine("Display value of obj:" + obj);

            Console.ReadKey();

        }
    }
}
