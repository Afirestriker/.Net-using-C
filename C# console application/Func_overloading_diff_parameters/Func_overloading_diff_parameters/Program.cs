using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Func_overloading_diff_parameters
{
    class Program
    {
        public
            //addtion of two int numbers
            int add(int n1, int n2)
            {
                Console.WriteLine("\nMethod two int numbers");
                return n1 + n2;
            }

            //addition of three int numbers
            int add(int n1, int n2, int n3)
            {
                Console.WriteLine("\nMethod three int numbers");
                return n1 + n2 + n3;
            }

        static void Main(string[] args)
        {
            Program obj = new Program();
            int sum;

            Console.WriteLine("\nProgram function overloading with different parameters");

            sum = obj.add(6, 2);
            Console.WriteLine("\n\tThe sum of two int numbers: " + sum);

            sum = obj.add(2, 2, 2);
            Console.WriteLine("\n\tThe sum of three int numbers: " + sum);

            Console.WriteLine("\nEnter any key to exist");
            Console.Read();

        }
    }
}
