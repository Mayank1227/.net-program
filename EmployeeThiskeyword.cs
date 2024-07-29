using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    public class Employee5
    {
        public int id;
        public String name;
        public float salary;
        public Employee5(int id, String name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }


    class EmployeeThiskeyword
    {
        static void Main(string[] args)
        {
            Employee5 obj = new Employee5(1001, "mayank", 12800.30f);

            obj.display();


            Console.ReadKey();

        }
    }
}
