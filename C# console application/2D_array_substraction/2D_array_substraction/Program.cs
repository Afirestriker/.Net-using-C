using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2D_array_substraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matrix1 = new int [3,3];
            int [,] matrix2 = new int [3,3];
            int [,] matrix3 = new int [3,3];

            Console.WriteLine("Program to perform substraction of matrix");

            Console.WriteLine("Enter Matrix A elements: ");
            for(int i=0; i<3; i++)
                for(int j=0; j<3; j++)
                    matrix1[i,j] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Matrix B elements: ");
            for(int i=0; i<3; i++)
                for(int j=0; j<3; j++)
                    matrix2[i,j] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Matrix A: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + matrix1[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            Console.WriteLine("Matrix B: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + matrix2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            Console.WriteLine("Substraction of Matrix A - Matrix B: ");
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    matrix3[i,j] = matrix1[i,j] - matrix2[i,j];
                    Console.Write("\t" + matrix3[i,j]);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
