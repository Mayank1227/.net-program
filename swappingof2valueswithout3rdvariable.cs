using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class swappingof2valueswithout3rdvariable
    {
        static void Main(string[] args)
        {

            int x, y;
            Console.WriteLine("Enter of the value of x and y:");

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("After swapping value of x:" + x);
            Console.WriteLine("After swapping value of y:" + y);

            Console.ReadKey();

        }
    }
}
