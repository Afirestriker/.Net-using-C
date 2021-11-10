using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Largest_of_two_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("This is a program to find out the largest of two number: \n");

            Console.Write("\t Enter number 01: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\t Enter number 02: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("\n\tLarger number is " + num1);
            else if (num1 < num2)
                Console.WriteLine("\n\tLarger number is " + num2);
            else
                Console.WriteLine("\n\tBoth number are equal");

            Console.ReadKey();
        }
    }
}
