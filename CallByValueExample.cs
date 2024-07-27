using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class CallByValueExample
    {
        public void Show(int val)
        {
            val*= val; //Manipulating value
            Console.WriteLine("Value inside the show function " + val); //2500
            // No return statement  
        }
        static void Main(string[] args)
        {
            int val = 50;
            CallByValueExample obj = new CallByValueExample();
            Console.WriteLine("Value before calling the function" + val);
            obj.Show(val);
            Console.WriteLine("Value After calling the function " + val); //50
            Console.ReadKey();
        }

        }
}
