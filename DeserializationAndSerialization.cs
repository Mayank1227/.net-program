using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    [Serializable]
    class DeserializationAndSerialization
    {
        public int ID;
        public String Name;

        public static void Main(string[] args)
        {
            DeserializationAndSerialization obj = new DeserializationAndSerialization();
            obj.ID = 1;
            obj.Name = "Asp.Net with C#";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\\MayankPatelCSharp\\FILEIO\\sss.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"D:\\MayankPatelCSharp\\FILEIO\\sss.txt", FileMode.Open, FileAccess.Read);
            DeserializationAndSerialization objnew = (DeserializationAndSerialization)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);

            stream.Close();

            Console.ReadKey();
        }




    }
}
