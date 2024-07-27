using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class Bike4
    {
        public Bike4()
        {
            Console.WriteLine("This is default constructor");
        }
         ~Bike4()  //tilde sign before the destructor
        {
            Console.WriteLine("This is destrctor called");
        }
        static public void Test()
        {
            Bike4 obj = new Bike4();
        }
        static void Main(string[]args)
        {
            Test();
            GC.Collect();
            Console.ReadKey();
        }
    }
}
