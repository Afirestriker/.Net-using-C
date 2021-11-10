using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sample_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1c, r2c, r3c, r4c;
            //jagged array
            int[][] jagged_arr = new int[4][];

            Console.WriteLine("Prgram to represent jagged array");

            //accept columns value for each row
            for (int i = 0; i < jagged_arr.Length; i++)
            {
                Console.Write("Enter the numbers of columns for row " + i + ":");
                if(i==0)
                {
                    r1c = Convert.ToInt32(Console.ReadLine());
                    jagged_arr[i] = new int [r1c];
                }
                else if(i==1)
                {
                    r2c = Convert.ToInt32(Console.ReadLine());
                    jagged_arr[i] = new int [r2c];
                }
                else if (i == 2)
                {
                    r3c = Convert.ToInt32(Console.ReadLine());
                    jagged_arr[i] = new int[r3c];
                }
                else if (i == 3)
                {
                    r4c = Convert.ToInt32(Console.ReadLine());
                    jagged_arr[i] = new int[r4c];
                }
            }

            for (int i = 0; i < jagged_arr.Length; i++)
            {
                Console.WriteLine("\nEnter jagged Array element for row " + i + ":");
                for (int j = 0; j < jagged_arr[i].Length; j++)
                    jagged_arr[i][j] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("\nThe jagged array is as follows: \n");
            for (int i = 0; i < jagged_arr.Length; i++)
            {
                for (int j = 0; j < jagged_arr[i].Length; j++)
                    Console.Write("\t" + jagged_arr[i][j]);

                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
