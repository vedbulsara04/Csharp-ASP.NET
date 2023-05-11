using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_User_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username :");
            string username = Console.ReadLine();

            Console.WriteLine("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + username + "!" + " You are " + age + " years old.");
            Console.ReadKey();
        }
    }
}
