using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameworkConsole2
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message)
            : base(message)
        {

        }
    }

    class TestUserDefinedException
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }

        }
        static void Main(string[] args)
        {
            try
            {
                validate(12);

            }catch(InvalidAgeException ex)
            {
                Console.WriteLine(ex);
            }

            
            Console.WriteLine("Rest of the code");
            Console.ReadKey();
        }
        }
}
