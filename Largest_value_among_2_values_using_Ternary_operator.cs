using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class Largest_value_among_2_values_using_Ternary_operator
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the value of a and b:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            string Numbera = "A Mex number", result;
            string Numberb = "B Mex number";

            result = a > b ? Numbera : Numberb;


            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
