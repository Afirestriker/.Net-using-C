using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jagged_array_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr = new int[4][];

            Console.WriteLine("Program to represent jagged array");

            jagged_arr[0] = new int[2] { 1, 2 };
            jagged_arr[1] = new int[3] { 1, 2, 3 };
            jagged_arr[2] = new int[4] { 1, 2, 3, 4 };
            jagged_arr[3] = new int[5] { 1, 2, 3, 4, 6 };

            Console.WriteLine("\tThis is jagged array with variable cols length \n\n");
            for (int i = 0; i < jagged_arr.Length; i++)
            {
                for (int j = 0; j < jagged_arr[i].Length; j++)
                {
                    Console.Write("\t" + jagged_arr[i][j]);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
