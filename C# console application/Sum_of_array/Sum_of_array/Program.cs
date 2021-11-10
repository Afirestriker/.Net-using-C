using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int i, num, sum = 0;

            Console.WriteLine("Enter the number of element to print: ");
            num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the elements: ");
            for (i = 0; i < num; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
                sum = sum + array[i];
            }

            Console.WriteLine("Display the sum: " + sum);

            Console.Read();
        }
    }
}
