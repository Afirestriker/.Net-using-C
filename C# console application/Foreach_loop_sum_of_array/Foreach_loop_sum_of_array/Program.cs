using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foreach_loop_sum_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 6 };
            int sum = 0;

            Console.WriteLine("\nProgram to display the sum of whole array: ");

            Console.WriteLine("\nDisplaying array elements \n");
            foreach (int i in array)
            {
                Console.Write("\t" + i);
                sum = sum + i;
            }

            Console.WriteLine("\n\nThe sum of array elements: " + sum);

            Console.Read();
        }
    }
}
