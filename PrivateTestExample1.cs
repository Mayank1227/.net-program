using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    class PrivateTestExample1
    {
        private string name = "Shantosh Kumar";
        private void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }



        static void Main(string[] args)
        {
            PrivateTestExample1 obj1 = new PrivateTestExample1();
            Console.WriteLine("Display name: " + obj1.name);
            obj1.Msg("Peter decosta");

            Console.ReadKey();



        }
        }
}
