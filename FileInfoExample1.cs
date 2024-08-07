using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class FileInfoExample1
    {
        static void Main(string[] args)
        {

            try
            {
                // Specifying file location  
                string loc = "D:\\MayankPatelCSharp\\FILEIO\\abc.txt";
                // Creating FileInfo instance  
                FileInfo file = new FileInfo(loc);
                // Creating an file instance to write  
                StreamWriter sw = file.CreateText();
                // Writing to the file  
                sw.WriteLine("This text is written to the file by using StreamWriter class.");
                sw.Close();
            } catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }


            Console.ReadKey();

    }
    }
}
