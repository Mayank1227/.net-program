using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class Employee
    {
        public int id;   //fields // members
        public String name;
        public float salary;
        public Employee()  //default constructor
        {
            Console.WriteLine("Defaul contructor called");
        }
        public Employee(int i, string n, float sal)  //Parameterized contructor
        {
            id = i; //Initialization
            name = n;
            salary = sal;
        }
        public void display()
        {
            Console.WriteLine("display employee id:" + id);
            Console.WriteLine("display employee name:" + name);
            Console.WriteLine("display employee salary:" + salary);
        }
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            Employee obj2 = new Employee(1009, "Mayank patel", 22800.30f);
            obj2.display();
            Console.ReadKey();
        }

    }

}
