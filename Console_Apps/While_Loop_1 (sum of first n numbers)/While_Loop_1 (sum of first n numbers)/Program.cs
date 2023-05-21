using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_1__sum_of_first_n_numbers_
{
    class While_Loop2
    {
        public static void Main(string[] args)
        {
            int i=1, sum=0;
            while (i <= 5)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine("Sum = {0}", sum);

         Console.ReadKey();
        }
    }
}
