using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor_default_constructor
{
    class add
    {
        private
            int num1, num2;

        public add()
        {
            num1 = 2;
            num2 = 4;
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
            add obj1 = new add();   //obj1 for class add is created, and default constructor is called

            Console.WriteLine("\nProgram to add two number using default constructor");

            Console.WriteLine("\nAddition: " + obj1.addition());

            Console.WriteLine("\nEnter any key to exist");
            Console.Read();
        }
    }
}
