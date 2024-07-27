using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirstConsoleApp1
{
    class AdditionInputProgram
    {

        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Enter the value of x and y:");
             x=Convert.ToInt32(  Console.ReadLine()); //method is used to get the input from console window

           y = Convert.ToInt32(Console.ReadLine());

          z=  x + y;

            Console.WriteLine("Display addition of x and y:" + z);

            Console.ReadKey();


        }

        }
}
