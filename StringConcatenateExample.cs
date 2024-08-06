using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    class StringConcatenateExample
    {
        static void Main(string[] args)
        {
            //string s1 = "Hello ";
            //string s2 = "C#";

            //  Console.WriteLine(string.Concat(s1, s2));
            //   Console.WriteLine(s1+s2);


            //------------------------------string contains method

            //string s1 = "Hello ";
            //string s2 = "He";
            //string s3 = "Hi";

            //Console.WriteLine(s1.Contains(s2));
            //Console.WriteLine(s1.Contains(s3));


            //----------------------string copy () method


            string s1 = "Hello ";
            string s2 = string.Copy(s1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);


            Console.ReadKey();



        }
    }
}
