using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2D_array_multiplication_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1, c1, r2, c2, i, j, k, sum = 0;

            int [,] matrixA = new int [20, 20];
            int [,] matrixB = new int [20, 20];
            int [,] matrixC = new int [20, 20];

            Console.WriteLine("Prgroam to perfrom multiplication of two matrices: \n");

            Console.WriteLine("\nSpecify the size of Rows and Columns for Matrix A:");
            Console.Write("\tMatrix A Row size: ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tMatrix A Column size: ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSpecify the size of Rows and Columns for Matrix B:");
            Console.Write("\tMatrix B Row size: ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tMatrix B Column size: ");
            c2 = Convert.ToInt32(Console.ReadLine());

            if (c1 != r2)
            {
                Console.WriteLine("The multiplication cannot be done");
                Console.WriteLine("since, the no. or column of matrix A is not equals to no. of rows in matrix B");
            }
            else
            {
                Console.WriteLine("\nEnter the elements for Matrix A: ");
                for(i=0; i<r1; i++)
                    for(j=0; j<c1; j++)
                        matrixA[i,j] = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("\nEnter the elements for Matrix B: ");
                for(i=0; i<r2; i++)
                    for(j=0; j<c2; j++)
                        matrixB[i,j] = Convert.ToInt32(Console.ReadLine());

                //Multiplication of MatrixA and MatrixB
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        sum = 0;
                        for (k = 0; k < c1; k++)
                        {
                            sum = sum + (matrixA[i, k] * matrixB[k, j]);
                        }
                        
                        matrixC[i, j] = sum;
                    }
                }

                Console.WriteLine("\n\nMatrix A: ");
                for(i=0; i<r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.Write("\t" + matrixA[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n\nMatrix B: ");
                for(i=0; i<r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("\t" + matrixB[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n\nMatrix C: ");
                for(i=0; i<r1; i++)
                {
                    for(j=0; j<c2; j++)
                    {
                        Console.Write("\t" + matrixC[i,j]);
                    }
                    Console.WriteLine();
                }

            }//else close

            Console.Read();

        }
    }
}
