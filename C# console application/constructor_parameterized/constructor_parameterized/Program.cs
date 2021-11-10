using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_parameterized
{
    class add
    {
        private
            int num1, num2;

        public add(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public int addition()
        {
            return num1 + num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            add obj1 = new add(2, 4);   //obj1 for class add is created, with parameterized constructor

            Console.WriteLine("\nProgram to add two numbers using parameterized constructor");

            Console.WriteLine("\nAddition: " + obj1.addition());

            Console.WriteLine("\nEnter any key to exist");
            Console.Read();
        }
    }
}
