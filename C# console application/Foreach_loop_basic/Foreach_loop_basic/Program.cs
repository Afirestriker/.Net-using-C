using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foreach_loop_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4 };

            Console.WriteLine("Program to represent working of foreach loop: ");

            Console.WriteLine("\nDisplaying array element uisng foreach loop: ");
            foreach (int i in array)
                Console.Write("\t" + i);

            Console.Read();
        }
    }
}
