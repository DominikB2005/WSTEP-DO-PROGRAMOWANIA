using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, suma = 0;

            do
            {
                Console.Write("Podaj liczbe: ");
                x = Convert.ToInt32(Console.ReadLine());
                suma += x;
            } while (x != 0);
            Console.WriteLine("suma = {0}", suma);
            Console.ReadKey(true);
        }
    }
}
