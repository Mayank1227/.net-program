using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    public class EmployeeDetail
    {
        public int empid;
        public string empName;//fields

        public void getDetails()
    {
        Console.WriteLine("Enter the employee id:");
        empid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the employee name:");
        empName = Console.ReadLine();
    }
    public void display()
    {
        Console.WriteLine("Enter The Employee id:" + empid);

        Console.WriteLine("display the employee name:" + empName);
    }
 }
        class EmployeeInformation
    {
          
        static void Main(string[] args)
        {
            EmployeeDetail obj = new EmployeeDetail();
            obj.getDetails();
            obj.display();

            Console.ReadKey();
        }
    }
}
