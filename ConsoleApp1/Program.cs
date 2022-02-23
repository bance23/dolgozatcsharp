using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írja be az intervallum kezdőértékét:");
            int intmin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Írja be az intervallum végértékét:");
            int intmax = Convert.ToInt32(Console.ReadLine());
            int aktszam = intmin - 1;

            for (int i = intmin; i <= intmax; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadKey();

        }
    }
}
