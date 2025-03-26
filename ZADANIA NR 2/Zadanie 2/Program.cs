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
            int a;
            Console.Write("podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("liczba {0} jest dodatnia", a);
            else if (a < 0)
                Console.WriteLine("liczba {0} jest ujemna", a);
            else
                Console.WriteLine("liczba {0} = 0", a);
            Console.ReadKey(true);
        }
    }
}
