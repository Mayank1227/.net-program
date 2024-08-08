using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class HashsetExample1
    {
        public static void Main(string[] args)
        {
            var names = new HashSet<string>() { "Sonoo", "Ankit", "Peter", "Irfan","Ankit" };
            //names.Add("Sonoo");
            //names.Add("Ankit");
            //names.Add("Peter");
            //names.Add("Irfan");
            //names.Add("Ankit");//will not be added  

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();

        }


    }
}
