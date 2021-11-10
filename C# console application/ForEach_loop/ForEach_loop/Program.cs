using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForEach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4] {1, 2, 3, 4};
            
            Console.WriteLine("Program to scan and display array element using ForEach loop: \n");

            Console.WriteLine("Enter the array elements:");
            foreach (int i in arr)
            {
                // dynamic allocation of array element using foreach loop is not recommended
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Display array elements: ");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
