using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class SwitchStatement
    {
        static void Main(string[] args)
        {
            char ch;


            Console.WriteLine("Enter the character");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("Its vowel");
                    break;

                default:
                    Console.WriteLine("Its Consonent");
                    break;
            }
            Console.ReadKey();
        }
    }
}
