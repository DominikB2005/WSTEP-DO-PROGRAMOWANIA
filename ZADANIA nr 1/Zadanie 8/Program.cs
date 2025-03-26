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
            double n, a;
            Console.WriteLine("Dany jest ciag a, ktory jest okreslony wzorem a(n)=3n-1");
            Console.Write("podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            a = 3 * n - 1;
            Console.WriteLine("a({0})={1}", n, a);
            Console.ReadKey(true);
        }
    }
}
