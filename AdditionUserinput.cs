using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class AdditionUserinput
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.WriteLine("Enter the value of A and B:");
            A = Convert.ToInt32(Console.ReadLine());

            B = Convert.ToInt32(Console.ReadLine());

            C = A + B;

            Console.WriteLine("Display addition of A and B:" + C);

            Console.ReadKey();

        }
    }
}
