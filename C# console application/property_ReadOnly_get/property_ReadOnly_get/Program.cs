using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace property_ReadOnly_get
{
    class ReadOnlyPorperty
    {
        private
            string first_name, last_name;

        //class constructor with 2 arguments
        public ReadOnlyPorperty(string fname, string lname)
        {
            first_name = fname;
            last_name = lname;
        }

        public string First_name        //property First_name, read only property since doesn't include set property method
        {
            get { return first_name; }  // get (read only property) method
        }

        public string Last_name         //property Last_name, read only property since doesn't include set property method
        {
            get { return last_name; }   // get (read only property) method
        }

    }   //class ReadOnlyProperty end

    class Program
    {
        static void Main(string[] args)
        {
            ReadOnlyPorperty GetDetail = new ReadOnlyPorperty("First_entry", "Second_entry");

            Console.WriteLine("\nFirstName: " + GetDetail.First_name);
            Console.WriteLine("\nLastName:  " + GetDetail.Last_name);

            Console.WriteLine("\nEnter key to exist \n");
            Console.Read();
        }
    }
}
