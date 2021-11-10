using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foreach_loop_max_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 6, 4 };
            int max = array[0];

            Console.WriteLine("\nProgram to find maximum element of array using foreach loop: ");

            Console.WriteLine("\nDisplaying array elements: \n");
            foreach (int i in array)
            {
                Console.Write("\t" + i);
                if (i > max)
                    max = i;
            }

            Console.WriteLine("\n\nThe maximum element of array: " + max);

            Console.Read();
        }
    }
}
