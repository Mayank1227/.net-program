using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingConsoleApp1
{
    class ThreadExample1
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "MainThread";
            Console.WriteLine(t.Name);
            Console.ReadKey();
        }
    }
}
