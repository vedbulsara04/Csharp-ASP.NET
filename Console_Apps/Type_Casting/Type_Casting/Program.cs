using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit type casting.
            int i = 9;
            double d = i;
            Console.WriteLine(i);
            Console.WriteLine(d);
            Console.WriteLine();

            // Explicit type casting.
            double a = 8.22;
            int b = (int)a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();


            // Type Conversion methods.
            int e = 7;
            double f = 7.77;
            bool g = true;

            Console.WriteLine(Convert.ToString(e)); // 7
            Console.WriteLine(Convert.ToDouble(e)); // 7
            Console.WriteLine(Convert.ToInt32(f));  // 8
            Console.WriteLine(Convert.ToInt64(f));  // 8
            Console.WriteLine(Convert.ToString(g)); // True

            Console.ReadKey();

        }
    }
}
