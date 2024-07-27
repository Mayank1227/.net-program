using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class Gradeofstudentaccordingtheirmarks
    {
        static void Main(string[] args)
        {

            int marks;

            Console.WriteLine("Enter the your Marks");
            marks = Convert.ToInt32(Console.ReadLine());

            if (marks > 80)
            {
                Console.WriteLine("You have  A grade.");
            }
            else if (marks >= 60 && marks <= 80)
            {
                Console.WriteLine("You have  B grade.");
            }
            else if (marks >= 40 && marks < 60)
            {
                Console.WriteLine("You have  C grade.");
            }
            else if (marks < 40)
            {
                Console.WriteLine("You have  D grade.");
            }
            else
            {
                Console.WriteLine("Invalid marks .");
            }

            Console.ReadKey();
        }
    }
}
