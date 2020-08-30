using System;

namespace CSharpReadingWritingToConsole
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            Console . WriteLine ( "Please Enter Your First Name: " );
            /* Reads User Input from the Console Using ReadLine()
             * Method and then Storing the Value in string*/
            string firstName = Console.ReadLine();

            Console . WriteLine ( "Please Enter Your Last Name: " );
            string lastName = Console.ReadLine();

            Console . WriteLine ( "Hello, {0} {1}!" , firstName , lastName );
        }
    }
}
