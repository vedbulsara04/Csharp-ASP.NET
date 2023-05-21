using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_3__foreach_loop_
{
    class ForEach
    {
        public static void Main(string[] args)
        {
            string[] formula1 = {"Mercedes AMG Petronas Formula1 team", "Scuderria Ferrari Fromula1 team", "Oracle Red-Bull racing Formula1 team"};

            foreach (string team in formula1)
            {
                Console.WriteLine(team);    
            }
            
            Console.ReadKey();
        }

    }
}
