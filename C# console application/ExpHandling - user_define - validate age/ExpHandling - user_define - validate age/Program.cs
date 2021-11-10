using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpHandling___user_define___validate_age
{
    //exception class
    public class InvalidAgeException : System.Exception // can also write just Exception instead of System.Exception
    {
        public InvalidAgeException(string message)
            : base(message) {}
        /* Mandatory to define parameterized constructor
         * Since here class *Exceptin* is inherited and it contain parameterized constructor
         * And as per rule: it base class contain parameterized constructor, then it is
           mandatory for derived class to have a parameterized and constructor and also pass
           parameter value to base class parameterized constructor
         * Here we are passing string type *message* to InvalidAge.... class and also exception class
           parameterized constructor*/
    }

    //Class to test user define exception
    public class TestUserDefineException
    {
        static public void validate(int age)
        {
            if(age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be above 18");
            }
        }//close validate()
    }//close TestUserDefineException class

    class Program
    {
        static void Main(string[] args)
        {
            //TestUserDefineException obj = new TestUserDefineException();

            try
            {
                //obj.validate(12); /* since it is a static function, can only be called using class name */
                TestUserDefineException.validate(12);

                /* Note: not mandatory to use function only,
                 * Instead we can alo use try and catch() directly 
                 * Example: */
                    //if (12 < 18)
                    //    throw new InvalidAgeException("Sorry, Age cannot be below 18");

            }
            catch(InvalidAgeException msg)
            {
                Console.WriteLine("Exception error: " + msg.Message);
            }
            Console.WriteLine("\n\nEnter any key to exit");
            Console.Read();

        }//main close
    }
}
