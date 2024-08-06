using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    class StringExample1
    {

        static void Main(string[] args)
        {

            string str1 = "hello"; //String Initialization

            char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };
            string str2 = new string(ch);

            Console.WriteLine("display value of str1:" + str1);

            Console.WriteLine("display value of str2: " + str2);
            Console.ReadKey();


        }

        }
}
