using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2,m,b;
            Console.Write("Podaj x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            m = (y2 - y1) / (x2 - x1);
            b = y1 - m * x1;
            Console.WriteLine("Rownainie prostej przechodzacej przez 2 punkty: (y-{0})*({1}-{2})-({3}-{0})*(x-{2})=0", y1, x2, x1, y2);
            Console.WriteLine("Wzor funckji liniowejj przechodzaacej przez 2 pkty: y = {0}*x+{1}", m, b);
            Console.ReadKey(true);

        }
    }
}
