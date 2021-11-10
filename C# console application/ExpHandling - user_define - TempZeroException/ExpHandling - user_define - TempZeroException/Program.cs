using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpHandling___user_define___TempZeroException
{

    //create user define exception
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string msg) : base(msg)
        { }
    }

    //class Temperature
    //{
    //    public void temp_value(int temp)
    //    {        
    //        if (temp == 0)
    //            throw new TempIsZeroException("Temperature value is zero");
    //        else
    //            Console.WriteLine("\nTemperature value is: " + temp);
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //Temperature tmp1 = new Temperature();
            int temp = 0;

            try
            {
                //tmp1.temp_value(02);

                if (temp == 0)
                    throw new TempIsZeroException("Temp is Zero");
                else
                    Console.WriteLine("\nTemperature is: " + temp);
            }
            catch (TempIsZeroException temperature)
            {
                Console.WriteLine("\n Exception: " + temperature.Message);
            }

            Console.WriteLine("\nEnter any key to exit");
            Console.Read();
        }
    }
}
