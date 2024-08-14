using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingConsoleApp1
{
    public class MyThread12
    {
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }

    }

    class ThreadSleepExample101
    {
        static void Main(string[] args)
        {
            MyThread12 mt = new MyThread12();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));

            Thread t2 = new Thread(new ThreadStart(mt.Thread1));

            t1.Start();
            t2.Start();

            Console.ReadKey();
        }

        }
}
