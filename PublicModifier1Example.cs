using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    class PublicTest
    {
        public string name = "Shantosh Kumar";
        public int age = 45;
        public void Msg(string msg)  //member function or method
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class PublicModifier1Example
    {
        static void Main(string[] args)
        {
            PublicTest obj = new PublicTest();

            Console.WriteLine("Display name :"+obj.name);
            Console.WriteLine("Display age :"+obj.age);

            obj.Msg("Peter Decosta");

            Console.ReadKey();

        }
        }
}
