using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class SumofArray2dInitialization
    {
        static void Main(string[] args)
        {
            int[,] array = {  { 1, 2, 3 }, { 4, 5, 6 },{ 7, 8, 9 } };

            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    sum += array[i, j];
                }
            }

            Console.WriteLine("The sum of the array elements is: " + sum);
            Console.ReadKey();
        }

        }
}
