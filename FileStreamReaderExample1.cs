using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class FileStreamReaderExample1
    {
        static void Main(string[] args)
        {

            FileStream f = new FileStream("D:\\MayankPatelCSharp\\FILEIO\\b1.txt", FileMode.OpenOrCreate);
            int i = 0;
            while ((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();

            Console.ReadKey();

        }
        }
}
