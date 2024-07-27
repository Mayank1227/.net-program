using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class EmpolyeeSub
    {
        public void ShowAdd(int a, int b)
        {
            int c;
            c = a - b;
            Console.WriteLine("Subtraction: " + c);
        }
        static void Main(string[] args)
        {
            EmpolyeeSub obj = new EmpolyeeSub();
            obj.ShowAdd(200, 56); 
            Console.ReadKey();
        }
    }
}
