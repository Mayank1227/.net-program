using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    abstract class AbstractClass
    {

        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public abstract int MultiplyTwoNumber(int n1, int n2);  //abstract method
    }


    class Derived3 : AbstractClass
    {
       public  override int MultiplyTwoNumber(int n1, int n2)
        {
            int result;
            result = n1 * n2;

            return result;
        }

    }

    
    class AbstractClassExample1
    {
        static void Main(string[] args)
        {
            //AbstractClass obj = new AbstractClass();

            Derived3 d = new Derived3();
            Console.WriteLine("Addition : {0}\n",
            d.AddTwoNumbers(4, 6));
           


            Console.WriteLine("Multiply : {0}", d.MultiplyTwoNumber(6, 4));

            Console.ReadKey();

        }


    }
}
