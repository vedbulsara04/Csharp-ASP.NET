using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace String_Methods_1
{
    public class StringMethods1
    {
        public static void Main(string[] args)
        {
            char[] ch = { 'V', 'e', 'd' };

            // String constructor with array of characters as a parameter.
            string str1 = new string(ch);
            Console.WriteLine(str1);
            Console.WriteLine();

            // String length.
            int length = str1.Length;
            Console.WriteLine("Length of str1 is : " + length);
            Console.WriteLine();

            // String concatenation.
            string str2 = "C#";
            string str3 = " Programming";
            string joinedString = string.Concat(str2, str3);

            Console.WriteLine("Concatenated string is : " + joinedString);
            Console.WriteLine("Concatenated string with method 2 : " + str2+str3);
            Console.WriteLine();

            // String comparison (equality check).
            Boolean equal1 = str1.Equals(str2);
            Console.WriteLine("Is str1 = str2 : " + equal1);

            // String comparison (dictionary position).
            Console.WriteLine("string str1 and str2 are equal: " + str1.CompareTo(str2));
            Console.WriteLine();

            // String interpolation.
            string name = "Ved";
            string message = $"Welcome {name}";
            Console.WriteLine(message);
            Console.WriteLine();

            // Index/Prescence of a character.
            int id = str2.IndexOf("#");
            Console.WriteLine("The index of '#' : " + id);

            /* <ERROR>
            //Joining with separator.
            string fname = "Ved";
            string lname = "Bulsara";             
            Console.WriteLine(string.Join(' ', fname, lname) + "\n"); */

            // String split method
            String str = "Welcome to C# Programming World";
            String[] spearator = { " " };
            Int32 count = 3; // maximum substring to return               
            String[] strlist = str.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);
            foreach (String s in strlist)
            {
                Console.WriteLine(s + "\n");
            }


            Console.ReadKey();
        }
    }
}
