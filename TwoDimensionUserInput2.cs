using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class TwoDimensionUserInput2
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];//declaration of 2D array  

            //sum of array elements using 2 d array Initialization



            Console.WriteLine("Enter the 2 D array elements:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Display the 2 D array elements:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");

                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }

 }

