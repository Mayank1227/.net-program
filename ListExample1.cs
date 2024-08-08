using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class ListExample1
    {
        public static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Sonoo Jaiswal");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Sonoo Jaiswal");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();



        }


        }
}
