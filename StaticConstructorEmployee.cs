using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    public class Account
    {
        public int id;
        public String name;
        public static float rateOfInterest;
        public Account(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        static Account()
        {
            rateOfInterest = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + rateOfInterest);
        }
    }



    class StaticConstructorEmployee
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(101, "Mayank patel");
            a1.display();

            Console.ReadKey();

        }
        }
}
