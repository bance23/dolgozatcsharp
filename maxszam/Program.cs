using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxszam
{
    class Program
    {
        static void Main(string[] args)
        {
            int aktszam = 1;
            int maxszam = 0;
            Console.WriteLine("Írjon be számokat majd üssön 0-t:");
            do
            {
                if (aktszam != 0)
                {   aktszam = Convert.ToInt32(Console.ReadLine());

                
                    if (aktszam > maxszam)
                    {
                        maxszam = aktszam;
                    }
                }

            } while (aktszam != 0);
            Console.WriteLine("Ez volt a legnagyobb szám:{0}", maxszam);
            Console.ReadKey();
        }
    }
}
