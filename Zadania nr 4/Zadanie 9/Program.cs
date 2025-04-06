using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 0;
            Console.Write("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                suma += n % 10;
                n = n / 10;

            }

            Console.WriteLine("Suma liczb = {0}", +suma);
            Console.ReadKey(true);
        }
    }
}



