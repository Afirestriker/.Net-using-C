using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance___single
{
    class base_class
    {
        public void display()
        {
            Console.WriteLine("This is base class method");
        }
    }

    class derived : base_class
    {
        public void display1()
        {
            Console.WriteLine("This is derived class method");
        }

        public void disp()
        {
            Console.WriteLine("\nThis is another derived class method, which also call base_class method in it");
            display();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            derived d1 = new derived();
            Console.WriteLine();

            d1.display();
            d1.display1();

            Console.WriteLine();

            d1.disp();

            Console.Write("\nEnter any key to exit");
            Console.Read();
        }
    }
}
