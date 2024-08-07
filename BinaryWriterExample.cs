using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class BinaryWriterExample
    {
        static void Main(string[] args)
        {
            string fileName = "D:\\MayankPatelCSharp\\FILEIO\\b5.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
            Console.WriteLine("Data written successfully...");
            Console.ReadKey();

        }



    }
}
