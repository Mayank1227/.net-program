using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    public class Number1 // Base class
    {
        public int n;  // member/field

        public void getNumber()
        {
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
        }

        public void displaySquare()
        {
            int square = n * n;
            Console.WriteLine("Square of the number: " + square);
        }
    }

    public class Cube : Number1  // derived class
    {
        public void displayCube()
        {
            int cube = n * n * n;
            Console.WriteLine("Cube of the number: " + cube);
        }
    }

    class SingleInheritanceExample2
    {
        static void Main(string[] args)
        {
            Cube obj = new Cube();
            obj.getNumber();
            obj.displaySquare();
            obj.displayCube();

            Console.ReadKey();
        }
    }
}

