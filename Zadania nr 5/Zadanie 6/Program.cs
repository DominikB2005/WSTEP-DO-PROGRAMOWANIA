using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, suma = 0;
            Console.Write("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
                suma += i * i;
            Console.WriteLine("1^1+...+{0}^{1}={2}", n, n, suma);
            Console.ReadKey(true);
          
                

        }
    }
}
