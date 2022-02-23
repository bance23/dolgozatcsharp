using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nszam
{
    class Program
    {
        static void Main(string[] args)
        {
            int paros = 0;
            int paratlan = 0;
            int aktszam = 0;
            Random rand = new Random();
            int number = rand.Next(5, 10);

            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("Írjon be egy számot:");
                aktszam = Convert.ToInt32(Console.ReadLine());

                if (aktszam % 2 == 0)
                {
                    paros++;
                }
                else
                {
                    paratlan++;
                }
            }
            Console.WriteLine("Ennyi páros szám volt:{0}", paros);
            Console.WriteLine("Ennyi páratlan szám volt:{0}", paratlan);
            Console.ReadKey();
        }
    }
}
