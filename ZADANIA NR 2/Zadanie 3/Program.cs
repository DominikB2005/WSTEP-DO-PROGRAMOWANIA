﻿using System;
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
            double a, b, c;
            Console.Write("podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj c: ");
            c = Convert.ToDouble(Console.ReadLine());
            if ((a <= b) && (a <= c))
                Console.WriteLine("liczba {0} jest najmniejsza", a);
            else if ((b <= a) && (b <= c))
                Console.WriteLine("liczba {0} jest najmniejsza", b);
            else 
                Console.WriteLine("liczba {0} jest najmniejsza", c);
            if ((a>=b) && (a>=c))
                Console.WriteLine("liczba {0} jest najwieksza", a);
            else if ((b >= a) && (b >= c))
                Console.WriteLine("liczba {0} jest najwieksza", b);
            else
                Console.WriteLine("liczba {0} jest najwieksza", c);
            Console.ReadKey(true);




        }
    }
}
