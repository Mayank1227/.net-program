using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    public class Employee8
    {
        private string name;
        private int age;
        private string address;  //fields

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name=value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }


    }

    class TestPropertiesEmployee
    {
        static void Main(string[] args)
        {
            Employee8 obj = new Employee8();
            obj.Name = "Kaushal suthariya";
            obj.Age = 21;
            obj.Address = "Upleta";

            Console.WriteLine("Display Name:" + obj.Name);

            Console.WriteLine("Display Age:" + obj.Age);
            Console.WriteLine("Display Address:" + obj.Address);

            Console.ReadKey();


        }
        }
}
