using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    class EnumExample1
    {

        public enum Season { WINTER, SPRING, SUMMER, FALL }

        static void Main(string[] args)
        {
            int f1, f2;
            f1 =(int) Season.WINTER;
            f2 = (int)Season.FALL;



            Console.WriteLine("display value of winter:" + f1);

            Console.WriteLine("display value of fall:" + f2);

            Console.ReadKey();

        }

        }
}
