using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface___simple
{
    interface Iinter
    {
        void display();
    }

    class derived : Iinter
    {

        public void display()
        {
            Console.WriteLine("\nThis is Iinter abstract method in derived class");
        }

        public void disp()
        {
            Console.WriteLine("\nInside deried class disp() method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            derived d1 = new derived();

            d1.display();
            d1.disp();

            Console.Write("\nEnter any key to exit");
            Console.Read();
        }
    }
}
