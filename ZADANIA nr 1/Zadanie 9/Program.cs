using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, k;
            Console.Write("podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());
            k = a * a + b * b;
            Console.WriteLine("kwadrat wczytanych liczb to {0}", k);
            Console.ReadKey(true);

        }
    }
}
