using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class FileStreamExample2
    {
        static void Main(string[] args)
        {
            //e:\\b.txt
            FileStream f = new FileStream("D:\\MayankPatelCSharp\\FILEIO\\b1.txt", FileMode.OpenOrCreate);
           for(int i=65;i<=90;i++)
            {

                f.WriteByte((byte)i);
            }
            f.Close();//closing stream  

            Console.ReadKey();
        }

    }
}
