using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string interpolation.
            Console.WriteLine("Enter your name :");
            string name = Console.ReadLine();

            string message = $"Welcome to C#, {name}!";
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
