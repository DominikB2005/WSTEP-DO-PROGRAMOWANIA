using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor;
            double a, b, h;

            do
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1 - oblicz pole prostokta");
                Console.WriteLine("2 - oblicz pole kwadratu");
                Console.WriteLine("3 - oblicz pole trojkata");
                Console.WriteLine("0 - koniec");
                wybor = Convert.ToInt32(Console.ReadLine());
                switch (wybor)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Podaj dlugosc boku a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj dlugosc boku b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole prostokata = {0}", a * b);
                        break;
                    case 2:
                        Console.Write("Podaj dlugosc boku a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole kwadratu = {0}", a * a);
                        break;
                    case 3:
                        Console.Write("Podaj dlugosc boku a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj dlugosc wysokosci h: ");
                        h = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole trojkata = {0}", (a * h) / 2);
                        break;
                    default:
                        Console.WriteLine("Blad - nieznany wybor");
                        break;

                }


            } while (wybor != 0);
            Console.ReadKey(true);
        }
    }
}
