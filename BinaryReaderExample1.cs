using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class BinaryReaderExample1
    {
        static void Main(string[] args)
        {
            using (BinaryReader reader = new BinaryReader(File.Open("D:\\MayankPatelCSharp\\FILEIO\\b5.txt", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }

            Console.ReadKey();

        }

    }
}
