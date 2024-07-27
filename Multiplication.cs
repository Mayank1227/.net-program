using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            int x, y, z, p;

            Console.WriteLine("Enter the value of x and y and z:");
            x = Convert.ToInt32(Console.ReadLine());

            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            p = x * y * z;

            Console.WriteLine("Display multiplication of x and y and z:" + p);

            Console.ReadKey();
        }
    }
}
