using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace property_Get_Set
{
    class get_set
    {
        private
            int num;
        public
            int number = 02;

        //public int Num      //property Read_write to read and write private data member /*num*/
        //{
        //    get     //get property to Read private data member /*num*/
        //    {
        //        return num;
        //    }
        //    set     //set property to write private data member /*num*/
        //    {
        //        num = value;
        //    }
        //}

        //short hand way to do it only while using get and set together
        public int Num
        {
            set;
            get;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            get_set obj1 = new get_set();

            obj1.Num = 6;

            Console.WriteLine("Num: " + obj1.Num);  
            //obj1.Num is property Num not private variable num;

            /*Property are useful to access and work with the private field/variable/functions of class
             *Two types of property
                1. get property --> To only read the private data of class
                2. set property --> To make changes to the private data of class
             * If use only get property, then it is called as Read_only property
             * If use only set property, then it is called as Write_only_property

             * Example:
             * If we want to set any value for data member like obj1.num = 01;
             * This will give compile error since "num" is private data member
             * Though we can make use of function to assing value to "num", 
                but in that case we have to pass the vaue as parameter for that function
             * And, better way to do it is using property, so that we can assign value by writting it in
             *      obj1.Num = 01 (here, we are not directly using "num" but "Num" i.e property "Num")
             *      NOTE: it is recommend and nice practice to have same name for property as of private
             *            data member name (*with change in uppper/lower case vlaue)
             *            so that it is more meaningful to read
             *            Instead of obj1.Name("string_parameter"); //in case of using function
            */

            Console.WriteLine("Enter key to exist");
            Console.Read();
        }
    }
}
