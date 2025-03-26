using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, min, max;
            Console.Write("Podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj c: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj d: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj e: ");
            e = Convert.ToDouble(Console.ReadLine());
            min = a;
            //najmniejsza liczba
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Liczba {0} jest najmniejsza", min);
            //najwieksza liczba
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Liczba {0} jest najwieksza ", max);
            Console.ReadKey(true);
        }
    }
}
