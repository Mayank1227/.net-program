using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class TernaryOperatorExample1
    {
        //WAP to print the person is Eligible for vote or not
        static void Main(string[] args)
        {
            int age;
            string eligible = "Eligible", result;
            string NotEligible = "Not Eligible";
            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            result = age >= 18 ? eligible : NotEligible;


            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
