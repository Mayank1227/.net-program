using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    class SortedSetExample2
    {
        public static void Main(string[] args)
        {

            // Using SortedSet class
            SortedSet<int> my_Set = new SortedSet<int>();

            // Add the elements in SortedSet
            // Using Add method
            my_Set.Add(101);
            my_Set.Add(1001);
            my_Set.Add(10001);
            my_Set.Add(100001);

            // After using Remove method
            Console.WriteLine("Total number of elements " +
                   "present in my_Set:{0}", my_Set.Count);

            // Remove element from SortedSet
            // Using Remove method
            my_Set.Remove(1001);

            // Before using Remove method
            Console.WriteLine("Total number of elements " +
                   "present in my_Set:{0}", my_Set.Count);

            // Remove all elements from SortedSet
            // Using Clear method

            foreach(var num in my_Set)
            {

                Console.WriteLine(num);
            }
            my_Set.Clear();
            Console.WriteLine("Total number of elements " +
                   "present in my_Set:{0}", my_Set.Count);

            Console.ReadKey();

        }
    }
}
