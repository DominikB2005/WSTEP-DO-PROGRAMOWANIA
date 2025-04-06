using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, i, j;
            Console.Write("Podaj liczbe naturalna dodatnia n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe naturalna dodatnia k ");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) //wiersze
            {
                for (j = 1; j <= k; j++)
                    Console.Write("*");
                Console.WriteLine();

            }
            Console.ReadKey(true);


        }
    }
}
