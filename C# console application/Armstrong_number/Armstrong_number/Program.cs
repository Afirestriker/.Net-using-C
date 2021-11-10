using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, d, sum=0, temp;

            Console.WriteLine("Program to find whether the given number is Armstrong or NOT \n");

            Console.Write("\tEnter the number: ");
            num = Convert.ToInt16(Console.ReadLine());
            temp = num;

            while (temp > 0)
            {
                d = temp % 10;
                sum = sum + (d * d * d);
                temp = temp / 10;
            }

            if (sum == num)
                Console.WriteLine("\n\tGiven Number is Armstrong \n");
            else
                Console.WriteLine("\n\tGiven Number is not Armstrong \n");

            Console.Read();
        }
    }
}
