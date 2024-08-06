using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    class ProtectedInternalMainExample1 : ClassLibrary2.Class1
    {
        static void Main(string[] args)
        {
            ProtectedInternalMainExample1 obj = new ProtectedInternalMainExample1();

            Console.WriteLine("Display rollno" + obj.rollno);
            Console.WriteLine("Display name" + obj.name);

            obj.DisplayFee(35000);

            Console.ReadKey();

        }
        }
}
