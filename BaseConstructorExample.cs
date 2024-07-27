using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent class contructor call...");
        }
    }
    public class Child:Parent
    {
        public Child()
        {
            Console.WriteLine("Chiled Class Contructor call...");
        }
    }

    class BaseConstructorExample
    {
        static void Main(string[] args)
        {
            Child objc = new Child();
            Console.ReadKey();
        }
        }
}
