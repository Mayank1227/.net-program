using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingConsoleApp1
{
    public class Animal
    {
        public virtual void eat() { Console.WriteLine("eating..."); }
        public virtual void run() { Console.WriteLine("running..."); }

    }
    public class Dog : Animal
    {
        public override void eat() { Console.WriteLine("eating bread..."); }
        public sealed override void run()
        {
            Console.WriteLine("running very fast...");
        }
    }
    public class BabyDog : Dog
    {
        public override void eat() { Console.WriteLine("eating biscuits..."); }
      //  public override void run() { Console.WriteLine("running slowly..."); }
    }


    class TestSealedMethodExample1
    {
        public static void Main()
        {

            BabyDog baby = new BabyDog();
            baby.eat();
            baby.run();
            Console.ReadKey();

        }


        }
}
