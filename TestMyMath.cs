using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    public static class MyMath
    {
        public static float PI = 3.14f;
        public static int cube(int n) { return n * n * n; }
    }


    class TestMyMath 
    {
        static void Main(string[] args)
        {
          //  MyMath obj = new MyMath(); cannot be instance

            Console.WriteLine("Value of PI is: " + MyMath.PI);
            Console.WriteLine("Cube of 3 is: " + MyMath.cube(3));

            Console.ReadKey();
        }



        }
    }
