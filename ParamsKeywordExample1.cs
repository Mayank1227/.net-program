using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class ParamsKeywordExample1
    {
        public void show (params object[] arr1)
        {
            for( int i = 0; i < arr1.Length;i++ )
            {
                Console.WriteLine(arr1[i]);
            }
        }
        static void Main(string[] args)
        {
            ParamsKeywordExample1 obj = new ParamsKeywordExample1();
            obj.show("Ramakrishnan Ayyer", "Ramesh", 101, 20.50, "Peter", 'A');
            Console.WriteLine("Showing integers: ");
            Console.ReadKey();
        }
    }
}
