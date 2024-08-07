using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace CollectionFrameworkConsole2
{
    class TextWriterExample
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("D:\\MayankPatelCSharp\\FILEIO\\b4.txt"))
            {
                writer.WriteLine("Hello C#");
                writer.WriteLine("C# File Handling by JavaTpoint");
            }

            Console.WriteLine("Data written successfully...");

            Console.ReadKey();

        }
        }
}
