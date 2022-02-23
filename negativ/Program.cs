using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negativ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írjon be egy számot");
            int szamelso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Írjon be még egy számot");
            int szammasodik = Convert.ToInt32(Console.ReadLine());

            if (szamelso > -1 && szammasodik > -1)
            {
                Console.WriteLine("Mind a kettő pozitív.");
            }
            if (szamelso < 0 && szammasodik > -1)
            {
                Console.WriteLine("Az első szám negatív.");
            }
            if (szamelso > -1 && szammasodik < 0)
            {
                Console.WriteLine("A második szám negatív.");
            }
            Console.ReadKey();
        }
    }
}
