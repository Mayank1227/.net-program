 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class _1DimArrayUserInputcs
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int limit;
            Console.WriteLine("enter the arry limit");
            limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("Enter the arry elements:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("Display the array elements:" + arr[i]);

            }

            Console.ReadKey();
        }
    
        }
}
