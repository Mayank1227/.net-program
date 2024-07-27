using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class TwoDimensionArray1
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 23, 56, 45 }};//2 D array Initialization
            Console.WriteLine("Display 2d array element");
            for(int r=0;r<3;r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(arr[r, c] + " ");  //arr[r][c]
                }
                Console.WriteLine();

            }

            Console.ReadKey();

        }
    }
}
