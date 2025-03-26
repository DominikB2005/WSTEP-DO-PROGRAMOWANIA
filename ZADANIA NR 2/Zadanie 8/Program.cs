using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Podaj bok a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj bok b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj bok c: ");
            c = Convert.ToDouble(Console.ReadLine());
            if ((a + b > c) && (b + c > a) && (a + c > b))
                Console.WriteLine("z tych odcinkow da sie zbudopwac trojkat");
            else
                Console.WriteLine("z tych odcinkow nie da sie zbudopwac trojkat");
            Console.ReadKey(true);

        }
    }
}
