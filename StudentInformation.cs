using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    public class StudentDetails

    {
        public int StudentNbr;
        public string StudentName;
        public int StudentClass;
        public string StudentSubject;
        public string StudentMoNumber;
        public string StudentSchoolName;
        public string StudentCity;

        public void getDetail()
        {
            Console.WriteLine("Enter Student number:");
            StudentNbr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            StudentName = Console.ReadLine();
            Console.WriteLine("Enter Student Class:");
            StudentClass = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Student subject:");
            StudentSubject = Console.ReadLine();
            Console.WriteLine("Enter Student Mo Number:");
            StudentMoNumber = Console.ReadLine();
            Console.WriteLine("Enter Student SchoolName:");
            StudentSchoolName = Console.ReadLine();
            Console.WriteLine("Enter Student City:");
            StudentCity = Console.ReadLine();
        }
            public void display()
            {
                Console.WriteLine("Enter Student number:"+StudentNbr);
                Console.WriteLine("Enter Student Name:"+StudentName);
                Console.WriteLine("Enter Student Class:"+StudentClass);
                Console.WriteLine("Enter your Student subject:"+StudentSubject);
                Console.WriteLine("Enter Student Mo Number:"+StudentMoNumber);
                Console.WriteLine("Enter Student SchoolName:"+StudentSchoolName);
                Console.WriteLine("Enter Student City:"+StudentCity);
            }
    }
    class StudentInformation
    {
        static void Main(string[] args)
        {
            StudentDetails obj = new StudentDetails();
            obj.getDetail();
            obj.display();
            Console.ReadKey();
        }

     }
}
