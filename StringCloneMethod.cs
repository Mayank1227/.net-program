using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    class StringCloneMethod
    {

        public static void Main(string[] args)
        {
            //string s1 = "Hello ";

            //  string s2 =(String) s1.Clone();



            //Console.WriteLine("display s1 value: " + s1);

            //Console.WriteLine("display s2 value: " + s2);


            //----------------------------String compare---------------

            //string s1 = "hello";
            //string s2 = "hello";
            //string s3 = "csharp";
            //string s4 = "mello";

            //Console.WriteLine(string.Compare(s1, s2));

            //Console.WriteLine(string.Compare(s2, s3));

            //Console.WriteLine(string.Compare(s3, s4));


            //------------------------------------------compareToMethod------------

            float value1 = 10.5f;

            // Declaring and initializing value2 
            float value2 = 20.6f;

            // compare both the values 
            // using CompareTo() method 
            int status = value1.CompareTo(value2);


            if(status>0)
            {
                Console.WriteLine("{0} is greater than {1}",
                                       value1, value2);
            }
            else if(status<0)
            {
                Console.WriteLine("{0} is less than {1}",
                                       value1, value2);
            }
            else
            {
                Console.WriteLine("{0} is equal to {1}",
                                    value1, value2);
            }

            Console.ReadKey();

        }


        }
}
