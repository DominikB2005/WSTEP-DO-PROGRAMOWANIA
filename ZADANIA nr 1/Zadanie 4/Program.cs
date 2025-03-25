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
            double a, b;
            Console.Write("Podaj dlugosc boku a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj dlugosc boku b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bok a={0}", a);
            Console.WriteLine("bok b={0}", b);
            Console.WriteLine("pole ={0}", a*b);
            Console.WriteLine("obw ={0}", 2*a+2*b);
            Console.ReadKey(true);
        }
    }
}
