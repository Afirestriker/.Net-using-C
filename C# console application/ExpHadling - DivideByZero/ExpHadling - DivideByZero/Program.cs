using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpHadling___DivideByZero
{
    class exp_handling
    {
        public int result = 0;

        public void division(int n1, int n2)
        {
            try
            {
                result = n1 / n2;
            }
            /* This catch statement will only cath exception DivideByZeroException
             * since it is explicitly mention and it will not catch any other Exception
             * To make it catch all exception we have to use *Exception* keyword intead of 
               particular exception name
             * i.e ---->   catch(Exception catc) { //catch statements; }  */

            catch (DivideByZeroException catc)  // catc is identifier not a inbuilt keyword
            {
                Console.WriteLine("\nExeption: " + catc);
            }
            finally //these statement will excecute either exception occurs or not
            {
                Console.WriteLine("\nResult (" + n1 + " / " + n2 + ") : " + result);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            exp_handling obj = new exp_handling();

            obj.division(2, 0);

            Console.WriteLine("\nEnter any key to exit");
            Console.Read();
        }
    }
}
