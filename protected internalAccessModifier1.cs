using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    class ProtectedInternal1
    {
        protected internal string name = "Chetan";
        protected internal int age = 20;

        protected internal void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }

    }
    class protected_internalAccessModifier1
    {

        static void Main(string[] args)
        {
            ProtectedInternal1 obj = new ProtectedInternal1();
            Console.WriteLine("Name is " + obj.name);

            Console.WriteLine("Age is " + obj.age);

            obj.Msg("abhishek vyas");

            Console.ReadKey();

        }

        }
}
