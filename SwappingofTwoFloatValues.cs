using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class SwappingofTwoFloatValues
    {
        static void Main(string[] args)
        {
            // float x = 12.5f, y = 66.89f; //Variable Initializaiton
            float x, y, z;
            Console.WriteLine("Enter of the value of x and y:");
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());

            z = x;
            x = y;
            y = z;

            Console.WriteLine("After swapping value of x:" + x);
            Console.WriteLine("After swapping value of y:" + y);



            Console.ReadKey();

        }
    }
}
