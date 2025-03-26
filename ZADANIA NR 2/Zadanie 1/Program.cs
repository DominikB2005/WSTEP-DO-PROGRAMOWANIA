using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("liczba {0} jest parzysta", a);
            else
                Console.WriteLine("liczba {0} jest nieparzysta", a);
            Console.ReadKey(true);
        }
    }
}
