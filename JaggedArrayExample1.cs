﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class JaggedArrayExample1
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];// Declare the array  

            arr[0] = new int[] { 11, 21, 56, 78 };// Initialize the array          
            arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
    
    
