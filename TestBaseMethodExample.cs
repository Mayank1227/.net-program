using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("eating...");
        }
    }
    public class Dog : Animal
    {
        public void eat()
        {
            base.eat();
            Console.WriteLine("eating bread...");
        }
    }
        class TestBaseMethodExample
        {
            static void Main(string[] args)
            {
                Dog obj = new Dog();
                obj.eat();
                Console.ReadKey();
            }
        }
    }
