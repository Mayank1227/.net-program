using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class OneDimensionArray1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 3, 4, 5, 6 }; //ARray Declaration and Initialization

            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.WriteLine("arr[{0}]={1}",i,arr[i]);
            foreach (var i in arr)
            {
                Console.WriteLine(i);

                //  Console.WriteLine("arr[{0}]={1}", i, arr[i]);
            }

            



            Console.ReadKey();

        }
    }
}
