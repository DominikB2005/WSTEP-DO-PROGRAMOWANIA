using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok;
            Console.Write("podaj rok: ");
            rok = Convert.ToInt32(Console.ReadLine());
            if ((rok % 4 == 0) && (rok % 100 != 0) || (rok % 400 == 0))
                Console.WriteLine("rok {0} jest przystepny", rok);
            else
                Console.WriteLine("rok {0} nie jest przystepny", rok);
            Console.ReadKey(true);
        }
    }
}
