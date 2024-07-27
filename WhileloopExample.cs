using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class WhileloopExample
    {
        static void Main(string[] args)
        {
            //WAP to print the numbers from 1 to 100

            int i = 1; //Initilization

            while (i <= 100) //condition
            {

                Console.WriteLine(i + "\t");

                i++; //Incre/Decr
            }


            Console.ReadKey();


        }
    }
}
