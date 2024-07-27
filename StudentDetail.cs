using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    public class TestStudent
    {
        public int rollno;
        public string studentName; //fields or members

    }
    //object is an instanc of a class or entity of a class
    class StudentDetail
    {
        static void Main(string[]args)
        {
            TestStudent obj = new TestStudent();
            obj.rollno = 20;
            obj.studentName = "Mayank Patel";
            Console.WriteLine("display rollno:" + obj.rollno);
            Console.WriteLine("display student name:" + obj.studentName);
            Console.ReadKey();
        }
    }
}
