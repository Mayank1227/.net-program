using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    public class Base
    {
      
        public virtual void show()
        {
            Console.WriteLine("Base CLass Show Nehod called");
        }
    }
    public class Derived :Base
    {
        public override void show()
        {
            Console.WriteLine("Derived class show method called");
        }
    }
    class MethodOverridingExample
    {
        static void Main(string[] args)
        {
            Derived objd = new Derived();
            objd.show();
            Console.ReadKey();
        }
        }
}
