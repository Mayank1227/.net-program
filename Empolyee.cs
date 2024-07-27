using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class Empolyee
    {
        public void ShowAdd(int a, int b)//method with paramter
        {
            int c;
            c = a + b;
            Console.WriteLine("Adition: " + c);
        }
        static void Main(string[] args)
        {
            Empolyee obj = new Empolyee();
            obj.ShowAdd(12, 3); // fuction call
            Console.ReadKey();
        }
    }
}

