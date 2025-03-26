using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, obj, pc;
            Console.Write("podaj a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj c:");
            c = Convert.ToDouble(Console.ReadLine());
            obj = a * b * c;
            pc = 2 * a * b + 2 * a * c + 2 * b * c;
            Console.WriteLine("objetosc = {0}, pole calkowite = {1}", obj, pc);
            Console.ReadKey(true);
        }
    }
}
