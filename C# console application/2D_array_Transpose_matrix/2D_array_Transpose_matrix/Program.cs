using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2D_array_Transpose_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;
            int[,] array = new int[6, 6];

            Console.WriteLine("Welcome to the program to find the transpose of matrix");

            Console.WriteLine("Enter the matrix size in rows and column");
            rows = Convert.ToInt32(Console.ReadLine());
            cols = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Enter Array elements");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Given matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("\t" + array[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n Transpost of a given matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("\t" + array[j, i]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
