using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingConsoleApp1
{
   
     public class MyThread14
    {
        public void Thread1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }
    class ThreadJoinMethodExample1
    {
        static void Main(string[] args)
        {
            MyThread14 mt = new MyThread14();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));

            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
            t3.Start();

            Console.ReadKey();

        }


        }
}
