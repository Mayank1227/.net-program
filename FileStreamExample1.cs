using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CollectionFrameworkConsole2
{
    class FileStreamExample1
    {

        static void Main(string[] args)
        {
            //e:\\b.txt
            FileStream f = new FileStream("D:\\MayankPatelCSharp\\FILEIO\\b.txt", FileMode.OpenOrCreate);
            f.WriteByte(65);//writing byte into stream  
            f.Close();//closing stream  

            Console.ReadKey();
        }



        }
}
