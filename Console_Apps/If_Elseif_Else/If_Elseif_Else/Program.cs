using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Elseif_Else
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Always choose different object_names to convert string to int.
            Console.WriteLine("Enter your age : ");
            string str_age = Console.ReadLine();            
            int age = Convert.ToInt32(str_age);
            Console.WriteLine("Your age is : " + age);
            Console.WriteLine();
            
            if(age <= 12)
            {
                Console.WriteLine("You are a child!");
            }
            else if(age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager!");
            }
            else
            {
                Console.WriteLine("You are an adult!");
            }
            
            Console.ReadKey();
        }
    }
}
