using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    public class Number //Base class
    {
        public int n1, n2;   //members/fields

        public void getNumber()
        {
            Console.WriteLine("Enter the number 1 and 2:");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
        }
        public class Addition : Number  //derived class
        {
            public void displayAdd()
            {
                int result = n1 + n2;

                Console.WriteLine("Addition of a and b: " + result);
            }

        }

        class SingleInheritanceExample1
        {
            static void Main(string[] args)
            {

                Addition obj = new Addition();
                obj.getNumber();
                obj.displayAdd();

                Console.ReadKey();

            }
        }
    }
}
