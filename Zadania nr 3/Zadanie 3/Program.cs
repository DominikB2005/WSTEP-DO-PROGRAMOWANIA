using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, suma = 0;
            Console.WriteLine("Warunkiem jest abys podal n>2");
            Console.Write("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                suma = suma + i;
            if (n <= 2)
                Console.WriteLine("Nie mozna wykonac");
            else if (n > 2)
                Console.WriteLine("1+2...+{0}={1}", n, suma);
            Console.ReadKey(true);
        }
    }
}
