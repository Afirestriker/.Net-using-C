using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance___multilevel
{
    class baseclass
    {
        public void b1()
        {
            Console.WriteLine("\n BaseClass method");
        }
    }

    class derived1 : baseclass
    {
        public void d1()
        {
            Console.WriteLine("\n Derived1 class method");
        }
    }

    class derived2 : derived1
    {
        public void d2()
        {
            Console.WriteLine("\n Derived2 class method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            derived2 d2 = new derived2();

            Console.WriteLine();

            d2.b1();
            d2.d1();
            d2.d2();

            Console.Write("\nEnter any key to exit");
            Console.Read();
        }
    }
}
