using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    class User
    {
        private protected string Name;
        private protected string Location;
        private protected int Age;
        private protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }

    
    class PrivateProtectedAccessModifier1 :User
    {
        static void Main(string[] args)
        {
            PrivateProtectedAccessModifier1 obj = new PrivateProtectedAccessModifier1();

            obj.Name = "Suresh bhai";
            obj.Age = 22;
            obj.Location = "Ahmedabad";
            obj.GetUserDetails();



            Console.ReadKey();
        }

        }
}
