using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Immutability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Strings are immutable*/
            string str1 = "Hello ";

            // Adding another string "Ved" to the previous string.
            str1 = string.Concat(str1, "Ved");

            /* 1) C# takes the value of the string as "Hello "
               2) Creates a new string object, gives it a value "Hello Ved",
                  and stores it in str1.
               3) The original string, "Hello ", that was assigned to str1 is
                  released for garbage collection because no other variable 
                  holds reference to it.    
            */

            Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
