using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class EncapsulationExampleCube
    {
        public class MathOperations
        {
        
            public double CalculateSquare(double num)
            {
                return num * num;
            }

            public double CalculateCube(double num)
            {
                return num * num * num;
            }

            private string formula = "n * n and n * n * n";

            public string DisplayFormula()
            {
                return formula;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
              
                MathOperations mathOps = new MathOperations();

               
                Console.Write("Enter a number: ");
                double number = Convert.ToDouble(Console.ReadLine());

                
                double square = mathOps.CalculateSquare(number);
                double cube = mathOps.CalculateCube(number);

               
                Console.WriteLine($"The square of {number} is {square}");
                Console.WriteLine($"The cube of {number} is {cube}");

                
                Console.WriteLine($"Formula used: {mathOps.DisplayFormula()}");

                Console.ReadKey();
            }
        }
    }
}

