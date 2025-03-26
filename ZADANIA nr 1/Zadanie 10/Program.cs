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
            double r, p, obw;
            Console.Write("podaj r: ");
            r = Convert.ToDouble(Console.ReadLine());
            p = Math.PI * r * r;
            obw = 2 * Math.PI * r;
            Console.WriteLine("pole = {0}, obwod = {1}", p, obw);
            Console.ReadKey(true);
        }
    }
}
