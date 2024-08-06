using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class StreamReaderExample1
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\MayankPatelCSharp\\FILEIO\\b3.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            //string line = s.ReadLine();


            //Console.WriteLine(line);

            string line = "";

            while((line=s.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }

            s.Close();
            f.Close();



            Console.ReadKey();

        }
    }
}
