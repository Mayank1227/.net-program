 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    public class Address
    {
        public String addressLine, city, state;
        public Address(string addressLine ,string city ,string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }
    public class Employee1
    {
        public int id;
        public string name;
        public Address address;//Employee HAS-A Address  
        public Employee1(int id ,string name,Address address)
        {
                this.id = id;
                this.name = name;
                this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " +
              address.addressLine + " " + address.city + " " + address.state);
        }

    }
    class TestAggregation
    {
        static void Main(string[] args)
        {
            Address addr = new Address("ShivranjaniRatanakar", "ahmedabad", "gujarat");
            Employee1 employee = new Employee1(1001, "Mayank", addr);

            employee.display();

            Console.ReadKey();

        }
    }
}
