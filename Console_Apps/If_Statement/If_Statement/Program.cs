using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Statements
{
    class if_statement
    {
        static public void Main()
        {
            Console.WriteLine("Enter a string 'x' : ");
            string x = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter a sting 'y' : ");
            string y = Console.ReadLine();
            Console.WriteLine();

            // If statement.
            if (x == y)
            {
                Console.WriteLine("'x' and 'y' strings are equal!");
            }

            // If statement.
            if (x != y)
            {
                Console.WriteLine("'x' and 'y' strings are not equal!");
            }

            Console.ReadKey();
        }
    }
}
