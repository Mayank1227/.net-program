using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    public class Base1
    {
        public string name = "Mayank";
    }
    public class Drived1 : Base1
    {
        string name = "Parth";
        public void showDetails()

        {
            Console.WriteLine(base.name);
            Console.WriteLine(name);
        }
    }
    class BaseClassFieldAccess
    {
        static void Main(string[] args)
        {
            Drived1 obj = new Drived1();
            obj.showDetails();
            Console.ReadKey();

        }
    }
}
