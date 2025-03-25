using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        private static object imie;

        static void Main(string[] args)
        {
            string imie;
            Console.Write("Napisz swoje imie: ");
            imie = Console.ReadLine();
            Console.WriteLine("Jestem {0}!", imie);
            Console.ReadKey(true);

            
        }
    }
}
