using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingConsoleApp1
{
    public class MyThread33
    {
        public static void Thread1()
        {
            Console.WriteLine("task one");
        }
        public static void Thread2()
        {
            Console.WriteLine("task two");
        }
    }
    class ThreadExample3
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MyThread33.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread33.Thread2));
            t1.Start();
            t2.Start();

            Console.ReadKey();
        }
        }
}
