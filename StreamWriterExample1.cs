using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class StreamWriterExample1
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\MayankPatelCSharp\\FILEIO\\b3.txt", FileMode.OpenOrCreate);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine("hello mayank bhai welocome");

            s.Close();
            f.Close();

            Console.WriteLine("File created successfully...");
            Console.ReadKey();

        }
    }
}
