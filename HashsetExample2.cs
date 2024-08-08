using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class HashsetExample2
    {
        public static void Main(string[] args)
        {

            HashSet<string> myhash = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash.Add("C");
            myhash.Add("C++");
            myhash.Add("C#");
            myhash.Add("Java");
            myhash.Add("Ruby");

            // Before using Remove method
            Console.WriteLine("Total number of elements present (Before Removal)" +
                                " in myhash: {0}", myhash.Count);

            // Remove element from HashSet
            // Using Remove method
            myhash.Remove("Ruby");

            // After using Remove method
            Console.WriteLine("Total number of elements present (After Removal)" +
                                " in myhash: {0}", myhash.Count);

            // Remove all elements from HashSet
            // Using Clear method
            myhash.Clear();
            Console.WriteLine("Total number of elements present" +
                                 " in myhash:{0}", myhash.Count);

            Console.ReadKey();

        }

        }
}
