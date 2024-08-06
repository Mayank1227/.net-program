using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        protected internal int rollno = 10;
        protected string name = "kaushal suthariya";
        protected internal void DisplayFee(int fees)
        {
            Console.WriteLine("My total fees is: " + fees);
        }
    }
}
