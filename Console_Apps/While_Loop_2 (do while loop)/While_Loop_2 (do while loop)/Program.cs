using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_2__do_while_loop_
{
    class DoWhile
    {
        public static void Main(string[] args)
        {
            int i = 1, n = 5, product;

            do
            {
                product = n * i;
                Console.Write("{0} + {1} = {2}", n, i, product);
                Console.WriteLine();
                i++;
            } while (i <= 10);


            Console.ReadKey();
        }
    }
}
