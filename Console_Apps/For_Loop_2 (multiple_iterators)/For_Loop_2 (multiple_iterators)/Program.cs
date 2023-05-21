using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_2__multiple_iterators_
{
    class ForLoop2
    {
        public static void Main(string[] args)
        {
            for (int i=0, j=0; i+j<=7; i++, j++)
            {
                Console.WriteLine("i = {0} and j = {1}", i,j);
                Console.ReadKey();
            }
        }
    }
}
