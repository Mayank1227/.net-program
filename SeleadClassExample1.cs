using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingConsoleApp1
{
    sealed class SealedAddition
    {
        public int Addition(int a,int b)
        {
            int c;

            c = a + b;
            return c;
        }
    }


    class SeleadClassExample1 
    {
        public static void Main()
        {
            SealedAddition obj = new SealedAddition();

            Console.WriteLine("display Addition: " + obj.Addition(11, 20));

            Console.ReadKey();


        }
        }
}
