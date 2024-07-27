using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class Subtraction
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Enter the value of x and y:");
            x = Convert.ToInt32(Console.ReadLine());

            y = Convert.ToInt32(Console.ReadLine());

            z = x - y;

            Console.WriteLine("Display subtraction of x and y:" + z);

            Console.ReadKey();
        }
    }
}
