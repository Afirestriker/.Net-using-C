using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 1, num;

            Console.WriteLine("Program to display the factorial of a given number:");

            Console.Write("\n\tEnter a number: ");
            num = Convert.ToInt16(Console.ReadLine());

            while (num != 0)
            {
                f = f*num;
                num--;
            }
            Console.WriteLine("\n\tFactorial of a given number is: " + f);

            Console.Read();
        }
    }
}
