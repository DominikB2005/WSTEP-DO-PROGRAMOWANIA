using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Podaj liczbe x= ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x^3={0}", x * x * x);
            Console.ReadKey(true);

            
        }
    }
}
