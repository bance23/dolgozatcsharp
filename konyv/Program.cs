using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyv
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldalszam = 0;
            string konyvcim = "";
            do
            {
                Console.WriteLine("Írja be a könyv címét:");
                konyvcim = Console.ReadLine();
                Console.WriteLine("Írja be hány oldal a könyv:");
                if (konyvcim != "")
                    oldalszam = Convert.ToInt32(Console.ReadLine());
                if (oldalszam > 150)
                {
                    Console.WriteLine("A {0} hosszú terjedelmű könyv.", konyvcim);
                }
                else
                {
                    Console.WriteLine("A {0} rövid terjedelmű könyv.", konyvcim);
                }
            } while (konyvcim != "");
        }
    }
}
