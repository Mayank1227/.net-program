using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirstConsoleApp1
{
    class StringExample
    {
        static void Main(string[] args)
        {
            string name; //store full name
            char ch; //Single character

            //string name1 = "Mayank";
            //char ch1 = 'M';

            Console.WriteLine("Enter the name of student");
            name = Console.ReadLine();

            Console.WriteLine("Enter the character");
            ch =Convert.ToChar( Console.ReadLine());


            Console.WriteLine("display name={0} and character={1}", name, ch);


            Console.ReadKey();



        }

        }
}
