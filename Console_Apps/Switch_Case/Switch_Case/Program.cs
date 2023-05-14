using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Formula1 World Driver Championships : ");
            string wdc_string = Console.ReadLine();
            int wdc = Convert.ToInt32(wdc_string);
            Console.WriteLine();

            switch (wdc)
            {
                case 1:
                    Console.WriteLine("Kimi Raikonnen : 1 x WDC");
                    break;
                case 2:
                    Console.WriteLine("Mika Hakkinen : 2 x WDC");
                    break;
                case 3:
                    Console.WriteLine("Ayrton Senna : 3 x WDC");
                    break;
                case 4:
                    Console.WriteLine("Sebastian Vettel : 4 x WDC");
                    break;
                case 5:
                    Console.WriteLine("Juan Manuel Fangio : 5 x WDC");
                    break;
                case 6:
                    Console.WriteLine("Michael Schumacher, Lewis Hamilton : 6 x WDC");
                    break;
                case 7:
                    Console.WriteLine("Michael Schumacher, Lewis Hamilton : 7 x WDC");
                    break;
            }    
            
            Console.ReadKey();
        }
    }
}
