using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            long silnia;
            Console.Write("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 1;
            silnia = 1;
            while (i <= n)
            {
                silnia *= i;
                i++;
               
            }
            Console.WriteLine("{0}!={1}", n, silnia);
            Console.ReadKey(true);
        }
    }
}
