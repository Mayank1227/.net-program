using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingConsoleApp1
{

    class Printer
    {

        // Display Function for
        // Dimension printing
        public virtual void show()
        {
            Console.WriteLine("display dimension : 6*6");
        }

        // Display Function
        public virtual void print()
        {
            Console.WriteLine("printer printing....\n");
        }
    }

    // inheriting class
    class LaserJet : Printer
    {

        // Sealed Display Function
        // for Dimension printing
        sealed override public void show()
        {
            Console.WriteLine("display dimension : 12*12");
        }

        // Function to override
        // Print() function
        override public void print()
        {
            Console.WriteLine("Laserjet printer printing....\n");
        }
    }

    // Officejet class cannot override show
    // function as it is sealed in LaserJet class.
    class Officejet : LaserJet
    {

        // can not override show function or else
        // compiler error : 'Officejet.show()' : 
        // cannot override inherited member
      
            
            
        // LaserJet.show() //' because it is sealed.
        override public void print()
        {
            Console.WriteLine("Officejet printer printing....");
        }
    }


    class SealedMethodExample22
    {
        public static void Main()
        {
            Printer p1 = new Printer();
            p1.show();

            p1.print();

            Printer p2 = new LaserJet();
            p2.show();
            p2.print();

            Printer of = new Officejet();
            of.show();
            of.print();

            Console.ReadKey();

        }

        }
}
