using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    class ProtectedTest
    {
        protected string name = "Shashikant";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }


    class ProtectedTestExample1 : ProtectedTest
    {
        static void Main(string[] args)
        {
            ProtectedTestExample1 obj = new ProtectedTestExample1();

            Console.WriteLine("Display name:" + obj.name);

            obj.Msg("Swami Ayyer");


            Console.ReadKey();
        }

        }
}