using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class MethodOverloading
    {
      public void add (int a,int b)
        {
            int c;
            c = a + b;
            Console.WriteLine("addition of a and b :" + c);
        }
        public void add (int a, int b,int c)
        {
            int d;
            d = a + b + c;
            Console.WriteLine("Addition of a b and c:" + d);

        }
        public float add(float a, float b)
        {
            return a + b;
        }
        static void Main(String[]args)
        {
            MethodOverloading obj = new MethodOverloading();
            obj.add(12, 20);
            obj.add(2, 3, 40);

            Console.WriteLine("Display addition of 2 float values:" + obj.add(12.5f, 3.4f));
            Console.ReadKey();

        }
    }
}
