using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpHandling___ArrayOutOfBound
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            Console.WriteLine("\nProgram to represent try and catch block of exception handling");

            try
            {
                /* Here we are checking inbuilt exception: IndexOutOfRangeException
                 * These catch() is not explicitly for IndexOutOfRangeException
                   But can check all other exception */
                Console.WriteLine("\nArray element 6: " + arr[6]);
            }
            catch (Exception catch_exp)
            {
                Console.WriteLine("\nException: " + catch_exp.Message);
            }

            /* These catch() is explicitly for IndexOutOfRangeException */
            //catch(IndexOutOfRangeException catch_exp) //Note: catch_exp is identifier, can use any name here
            //{
            //Console.WriteLine("\nException: " + catch_exp.Message);  
            //}


            Console.WriteLine("\nEnter any key to exit");
            Console.Read();

        }
    }
}