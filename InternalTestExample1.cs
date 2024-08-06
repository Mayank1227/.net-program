using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    class InternalTestExample1
    {
        static void Main(string[] args)
        {
            InternalAccessModifier101 obj = new InternalAccessModifier101();

            Console.WriteLine("Display empid : " + obj.empid);

            Console.WriteLine("Display empName : " + obj.empname);
            Console.WriteLine("Display salary : " + obj.sal);

            Console.ReadKey();


        }
        }
}
