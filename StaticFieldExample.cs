using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectExamplesConsoleApp1
{
    public class College
    {
        public int rollno;
        public String sname;
        public static string CollegeName = "Silver oak college";

        public static int count = 0;
        public College(int rno, String name1)
        {
            rollno=rno;
            sname = name1;
            count++;
        }

        public void display()
        {
            Console.WriteLine(rollno + " " + sname + " " + CollegeName);
        }
    }

    class StaticFieldExample
    {
        static void Main(string[] args)
        {
            College objc = new College(12, "Jay pandya");
            College objc1 = new College(18, "Milen");

            objc.display();
            objc1.display();
           
            Console.WriteLine("Total Objects are: " + College.count);

            Console.ReadKey();
            //static field will be accessed using className
        }
        }
}
