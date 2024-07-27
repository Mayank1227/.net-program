using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class IFElseStatement1
    {
        static void Main(string[] args)
        {
            //eligible for voting
            int age;
            char citizen;

            Console.WriteLine("Enter the citizen shp of person");
            citizen = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the Age person");
            age = Convert.ToInt32(Console.ReadLine());

            if (citizen == 'I' || citizen == 'i' && age >= 18)
            {
                Console.WriteLine("Eligible for vot");

            }
            else
            {
                Console.WriteLine("Not Eligible for vot");
            }
            Console.ReadKey();

        }
    }
}
