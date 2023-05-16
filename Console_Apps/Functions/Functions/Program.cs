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
            Console.WriteLine("Enter num1 : ");
            string num1_str = Console.ReadLine();
            int num1 = Convert.ToInt32(num1_str);

            Console.WriteLine("Enter num2 : ");
            string num2_str = Console.ReadLine();
            int num2 = Convert.ToInt32(num2_str);

            Program program = new Program();
            int sum = program.add_num(num1, num2);
            Console.WriteLine("Addition of the numbers " + num1 + " and " + num2 + " is : " + sum);            
            
            Console.ReadKey();
        }
    }
}
