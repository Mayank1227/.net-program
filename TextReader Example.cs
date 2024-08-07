using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CollectionFrameworkConsole2
{
    class TextReader_Example
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("D:\\MayankPatelCSharp\\FILEIO\\b4.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }

            Console.ReadKey();
        }
        }
}
