using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2D_array_addition_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[, ] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] array3 = new int[3, 3];

            Console.WriteLine("Program to display matrix addition");

            Console.WriteLine("Enter Matrix A: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter Matrix B: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n\tAddition of both matrix: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array3[i, j] = array1[i,j] + array2[i,j];
                    Console.Write("\t" + array3[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
