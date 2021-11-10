using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do
            {
                Console.WriteLine("value i: "+i);
                i++;
            } while(i <= 3);

            Console.Read();
        }
    }
}
