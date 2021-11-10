using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practice_program
{

    //value type and refrencd type

    class program
    {
        static void valuetype(int i)
        {
            i = 200;
        }

        static void referencetype(ref int i)
        {
            i = 400;
        }

        static void Main()
	{
		int i= 100;

		Console.WriteLine("\nDefault value of i: " + i);
		
		valuetype(i);
		Console.WriteLine("\nValue of i after valuetype(): " + i);

        referencetype(ref i);
		Console.WriteLine("\nvalue of i after referencetpe(): " + i);
		
		Console.Read();
	}

    }//class program close

}//namespace end
