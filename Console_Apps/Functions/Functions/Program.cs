using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        // user defined function.
        public int add_num(int a, int b)
        {
            return a + b;
        }

        // Main function, execution entry point of the program 
        static void Main(string[] args)
        {
            Program program = new Program();
            int sum = program.add_num(3, 4);
            Console.WriteLine("Addition of 2 numbers is : " + sum);
            
            Console.ReadKey();
        }
    }
}
