using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rev=0, d, temp;

            Console.WriteLine("Program to check whether given number is palindrome or not \n");

            Console.Write("\tEnter the number: ");
            num = Convert.ToInt16(Console.ReadLine());

            temp = num;
            while (temp > 0)
            {
                d = temp % 10;
                rev = (rev * 10) + d;
                temp = temp / 10;
            }

            if (rev == num)
                Console.WriteLine("\n\tGiven number is palindrome number \n");
            else
                Console.WriteLine("\n\tGiven number is not palindrome number \n");

            Console.Read();
        }
    }
}
