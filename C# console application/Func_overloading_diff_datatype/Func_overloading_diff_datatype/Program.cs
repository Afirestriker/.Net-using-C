using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Func_overloading_diff_datatype
{
    class Program
    {
        //addition of int number
        public 
        int add(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }

        //addition of double number
        double add(double n1, double n2)
        {
            double sum = n1 + n2;
            return sum;
        }

        static void Main(string[] args)
        {
            Program obj1 = new Program();

            int int_sum;
            double double_sum;

            Console.WriteLine("\nProgram overloading function with different data types");

            int_sum = obj1.add(6, 6);
            Console.WriteLine("\n\tThe sum of integer number: " + int_sum);

            double_sum = obj1.add(6.6, 6.2);
            Console.WriteLine("\n\tThe sum of double number: " + double_sum);

            Console.WriteLine("\nEnter any key to exist");
            Console.Read();
        }
    }
}
