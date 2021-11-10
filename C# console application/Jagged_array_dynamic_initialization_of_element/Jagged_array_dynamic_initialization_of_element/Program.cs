using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jagged_array_dynamic_initialization_of_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1c, r2c, r3c, r4c;
            int[][] jagged_array = new int[4][];

            Console.WriteLine("Program to demonstrate jagged array with scanning value from user and display the entered value \n");

            Console.WriteLine("\nEnter the number of columns for each row: ");
            for (int i = 0; i < jagged_array.Length; i++)
            {
                int num = i+1;
                Console.Write("\tRow " + num + ": ");
                if (i == 0)
                {
                    r1c = Convert.ToInt32(Console.ReadLine());
                    jagged_array[i] = new int[r1c];
                }

                else if (i == 1)
                {
                    r2c = Convert.ToInt32(Console.ReadLine());
                    jagged_array[i] = new int[r2c];
                }

                else if (i == 2)
                {
                    r3c = Convert.ToInt32(Console.ReadLine());
                    jagged_array[i] = new int[r3c];
                }

                else if (i == 3)
                {
                    r4c = Convert.ToInt32(Console.ReadLine());
                    jagged_array[i] = new int[r4c];
                }
            }

            Console.WriteLine("\nEnter the elements for each row with columns specified: \n");
            for (int i = 0; i < jagged_array.Length; i++)
            {
                int num = i+1;
                Console.WriteLine("Row " + num + " elements:");

                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    jagged_array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nDisplaying jagged array elements:");
            for (int i = 0; i < jagged_array.Length; i++)
            {
                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    Console.Write("\t" + jagged_array[i][j]);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
