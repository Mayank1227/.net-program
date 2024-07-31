using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    interface calc1
    {
        int add(int a, int b);
    }

    interface calc2
    {
        int sub(int a, int b);
    }

    interface calc3
    {
        int mul(int a, int b);
    }

    interface calc4
    {
        int div(int a, int b);
    }

    class Calculation : calc1, calc2, calc3, calc4
    {

        public int result1;
        public int result2;
        public int result3;
        public int result4;

        public int add(int a, int b)
        {

            result1 = a + b;
            return result1;

        }
        public int sub(int x, int y)
        {

            result2 = x-y;
            return result2;

        }
        public int mul(int r, int s)
        {

            result3 = r*s;
            return result3;

        }
        public int div(int fir, int sec)
        {

            result4 = fir/sec;
            return result4;

        }

    }
    class MultipleInterfaceExample1
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
          
            Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");
            Console.WriteLine("Addition: " + c.add(8, 2));
            Console.WriteLine("Substraction: " + c.sub(20, 10));
            Console.WriteLine("Multiplication :" + c.mul(5, 2));
            Console.WriteLine("Division: " + c.div(20, 10));

            Console.ReadKey();


        }
    }
}
