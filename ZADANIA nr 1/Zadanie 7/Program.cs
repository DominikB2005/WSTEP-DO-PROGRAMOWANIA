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
            double a, b, iloraz, reszta;
            Console.Write("Podaj a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b=");
            b = Convert.ToDouble(Console.ReadLine());
            iloraz = a / b;
            reszta = a % b;
            Console.WriteLine("iloraz={0}/{1}={2}r{3}", a, b, a / b, a % b);
            Console.ReadKey(true);
        }
    }
}

