using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    public class MM
    {
        public int rollno;
        public void get_Rollno(int rn)
        {
            rollno = rn;
        }
        public void put_Rollno()
        {
            Console.WriteLine("display rollno: " + rollno);
        }
    }

    public class Marks : MM
    {
        protected int sub1, sub2;

        public void get_Marks(int s1, int s2)
        {
            sub1 = s1;
            sub2 = s2;
        }
        public void put_Marks()
        {
            Console.WriteLine("display subject 1 marks: " + sub1);
            Console.WriteLine("display subject 2 marks: " + sub2);
        }
    }
    class MultilevelInheritance : Marks
    {
        protected float tot;

        public void disp()
        {
            tot = sub1 + sub2;
            put_Rollno();
            put_Marks();
            Console.WriteLine("Display total marks of sub1 and sub2: " + tot);
        }
        static void Main(string[] args)
        {
            MultilevelInheritance obj = new MultilevelInheritance();
            obj.get_Rollno(22);
            obj.get_Marks(80, 94);
            obj.disp();

            Console.ReadKey();
        }
    }
}

