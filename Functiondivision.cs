using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class Functiondivision
    {
        public void showdivi(int a, int b)
        {
         int c;
         c = a / b;
            Console.Write("Division:" + c);
        }
       static void Main(string[] args)
        {
            Functiondivision obj = new Functiondivision();
            obj.showdivi(20, 5);
            Console.ReadKey();
        }   
    }
}
