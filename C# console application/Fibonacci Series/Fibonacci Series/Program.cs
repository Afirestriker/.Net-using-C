using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c, num;

            Console.WriteLine("Program to display Fibonacci Series of given number:");

            Console.Write("\n\tEnter the number: ");
            num = Convert.ToInt16(Console.ReadLine());

            Console.Write("\n\tFibonacci series: ");
            Console.Write(a);
            Console.Write(" " + b);

            for (int i = 2; i < num; i++)
            {
                c = a + b;

                Console.Write(" " + c);

                a = b;
                b = c;
            }

            Console.Read();
        }
    }
}
