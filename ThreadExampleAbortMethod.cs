using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingConsoleApp1
{
    public class MyThread13
    {
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }
    class ThreadExampleAbortMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main");
            MyThread13 mt = new MyThread13();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));

            t1.Start();
            t2.Start();
            try
            {
               t1.Abort();
                t2.Abort();
            }
            catch (ThreadAbortException tae)
            {
                Console.WriteLine(tae.ToString());
            }
            Console.WriteLine("End of Main");

            Console.ReadKey();

        }
        }
}
