using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface___multiple
{
    interface Iinter1
    {
        void Idisp1();
    }

    interface Iinter2
    {
        void Idisp2();
    }

    class base_class : Iinter1, Iinter2
    {
        public void base_class_disp()
        {
            Console.WriteLine("\nBase_class method");
        }

        public void Idisp2()
        {
            Console.WriteLine("\nIdisp2 method");
        }

        public void Idisp1()
        {
            Console.WriteLine("\nIdisp1 method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            base_class b1 = new base_class();
            Iinter1 Iobj1 = new base_class();
            Iinter2 Iobj2 = new base_class();

            b1.base_class_disp();
            b1.Idisp1();
            b1.Idisp2();

            Console.WriteLine("\n\nMethod called through individual interface object");
            Iobj1.Idisp1();
            Iobj2.Idisp2();

            Console.Write("\nEnter any key to exit");
            Console.Read();
        }
    }
}
