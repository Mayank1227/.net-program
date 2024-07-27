using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class ParamsExample2
    {
        public void display(params int[]arr2)
        {
            for(int i=0;i<arr2.Length;i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
        static void Main(string[] args)
        {
            ParamsExample2 obj = new ParamsExample2();
            obj.display(12, 3, 4, 5, 7, 90);
            Console.ReadKey();
        }
        }
}
