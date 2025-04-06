using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor;
            double kwotapln, euro, dolar, funt;
            Console.Write("Podaj kwote w pln: ");
            kwotapln = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Na jaka walute chcesz wymienic pln?");
            Console.WriteLine("1 - na euro");
            Console.WriteLine("2 - na funty");
            Console.WriteLine("3 - na dolary");
            Console.WriteLine("0 - Nie chce wymienic waluty");
            Console.Write("Twoj wybor: ");
            wybor = Convert.ToInt32(Console.ReadLine());
            euro = kwotapln / 4.24;
            dolar = kwotapln / 3.85;
            funt = kwotapln / 5.01;


            switch (wybor)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("{0} pln = {1:F2} euro", kwotapln, euro);
                    break;
                case 2:
                    Console.WriteLine("{0} pln = {1:F2} funtow", kwotapln, funt);
                    break;
                case 3:
                    Console.WriteLine("{0} pln = {1:F2} $", kwotapln, dolar);
                    break;
                default:
                    Console.WriteLine("Niezany wybor");
                    break;


            }
            Console.ReadKey(true);
        }
    }
}
