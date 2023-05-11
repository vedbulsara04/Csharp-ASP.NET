using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Statement
{
    class If_Else
    {
        static public void Main()
        {
            Console.WriteLine("Enter a string value for 'str1' : ");
            string str1 = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("Enter a string value for 'str2' : ");
            string str2 = Console.ReadLine();
            Console.WriteLine();

            if (str1 == str2)
            {
                Console.WriteLine("Both strings are equal!");
            }
            else
            {
                Console.WriteLine("Both strings are not equal!");
            }
            
            Console.ReadKey();
        }
    }
}
