using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Reading the username.
            Console.WriteLine("Enter your username : ");
            string uname = Console.ReadLine();
            Console.WriteLine();

            // Reading the password.
            Console.WriteLine("Enter your password : ");
            string pass = Console.ReadLine();
            Console.WriteLine();

            /*Nested-if Conditional statement to check username & password*/
            if(uname == "vedbulsara04")
            {
                if(pass == "ved123")
                {
                    Console.WriteLine("Login Success!");
                }
            }                                           
            Console.WriteLine("Login unsuccessful");
            Console.ReadKey();
        }
    }
}
