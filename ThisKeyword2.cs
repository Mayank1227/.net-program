using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    class ThisKeyword2
    {
        int num1;
        int num2;

        ThisKeyword2()
        {
            num1 = 22;
            num2 = 33;
        }

        // method that accepts this as argument   
        void passParameter(ThisKeyword2 t1)
        {
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
        }

        void display()
        {
            // passing this as a parameter
            passParameter(this);
        }

        
        static void Main(string[] args)
        {
            ThisKeyword2 t1 = new ThisKeyword2();
            t1.display();
            Console.ReadKey();

        }
        }
}
