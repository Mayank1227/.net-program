using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class ElseifLadderStatementExample
    {
        static void Main(string[] args)
        {
            //WAP to print the addition,subtraction



            int choice, a, b, c;

            Console.WriteLine("Chioce 1 for Addition:");
            Console.WriteLine("Chioce 2 for Subtraction:");
            Console.WriteLine("Chioce 3 for Mutlply:");

            Console.WriteLine("Enter the your choice");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice <= 3)
            {
                Console.WriteLine("Enter the value of a and b:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {

                    c = a + b;
                    Console.WriteLine("Addition of a and b:" + c);
                }
                else if (choice == 2)
                {
                    c = a - b;
                    Console.WriteLine("Subtraction of a and b:" + c);
                }
                else
                {
                    c = a * b;
                    Console.WriteLine("Multiplication of a and b:" + c);
                }

            }
            else
            {

                Console.WriteLine("Wrong chioce?? please enter 1 to 3 choices");
            }


            Console.ReadKey();


        }
    }
}
