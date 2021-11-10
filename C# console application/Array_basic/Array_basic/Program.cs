using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int[5];
            int i;

            Console.WriteLine("Enter array element: ");
            for(i=0; i<5; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Display The array: ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Array: " + array[i]);
            }

            Console.Read();
        }
    }
}
