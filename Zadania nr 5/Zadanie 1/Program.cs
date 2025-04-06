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
            double x, y;
            Console.Write("Podaj x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj y: ");
            y = Convert.ToDouble(Console.ReadLine());

            //ktora cwiartka
            if ((x > 0) && (y > 0))
                Console.WriteLine("Punkt nalezy do cwiartki 1");
            else if ((x < 0) && (y > 0))
                Console.WriteLine("Punkt nalezy do cwiartki 2");
            else if ((x < 0) && (y < 0))
                Console.WriteLine("Punkt nalezy do cwiartki 3");
            else if ((x > 0) && (y < 0))
                Console.WriteLine("Punkt nalezy do cwiartki 4");
            else if ((x==0)&&(y==0))
                Console.WriteLine("Punkt nie nalezy do zadnej cwiartki");


            //czy nalezy do ox czy oy
            if ((x != 0) && (y == 0))
                Console.WriteLine("Punkt nalezy do osi oX");
            else if ((x == 0) && (y != 0))
                Console.WriteLine("Punkt nalezy do osi ox");
            else if ((x == 0) && (y == 0))
                Console.WriteLine("Punkt nalezy do osi ox i oy");

            Console.ReadKey(true);
        }
    }
}
