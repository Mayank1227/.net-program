using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class OutParameterExample2
    {
        public void show (out int a,out int b)//out parameter
        {
            int square = 5;
            a = square;
            b = square;
            // Manipulating value   
            a *= a;
            b *= b;
        }
        static void Main(string[] args)
        {
         

              int val1 = 50, val2 = 100;
            OutParameterExample2 obj = new OutParameterExample2(); // Creating Object  
                                                                   //  Console.WriteLine("Value before passing \n val1 = " + val1 + " \n val2 = " + val2);
            obj.show(out val1, out val2); // Passing out argument  
            Console.WriteLine("Value after passing \n val1 = " + val1 + " \n val2 = " + val2);


            Console.ReadKey();
        }
    }
}
