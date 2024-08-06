using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class finallyException
    {
        static void Main(string[] args)
        {

            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            finally {
                Console.WriteLine("Finally block will be executed");
                    
                    }
            Console.WriteLine("Rest of the code");

            Console.ReadKey();



        }



    }
}
