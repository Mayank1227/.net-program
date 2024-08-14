using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingConsoleApp1
{
    class AnonymousMethods1
    {
        public delegate void AnonymousFun();  
        static void Main(string[] args)
        {
            AnonymousFun fun = delegate ()  //AnonymousFun definition
            {
                Console.WriteLine("This is anonymous function");
            };
            fun(); 

            Console.ReadKey();
        }


        }
}
