using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Property_WriteOnly_Set
{
    class Program
    {

        //class declaration
        class WriteOnly
        {
            private
                string name, address;

            public string Set_name  //property
            {
                set     //set property
                {
                    name = value;
                }
            }

            public string set_addr  //property
            {   
                set     //set property
                {
                    address = value;
                }
            }

            //displaying details
            public void getdetails()
            {
                Console.WriteLine("\nName:    " + name);
                Console.WriteLine("\nAddress: " + address);
            }
        }


        static void Main(string[] args)
        {
            //main() function

            WriteOnly obj1 = new WriteOnly();

            obj1.Set_name = "Name_str";
            obj1.set_addr = "Addr_str";

            obj1.getdetails();

            Console.WriteLine("\nEnter key to exist");
            Console.Read();
        }
    }
}
