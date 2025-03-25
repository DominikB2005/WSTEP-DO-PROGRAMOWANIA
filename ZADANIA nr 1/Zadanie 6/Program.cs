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
            double a, b, suma, roznica, iloczyn, iloraz;
            Console.Write("podaj a= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj b= ");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("suma={0}", suma);
            Console.WriteLine("roznica={0}", roznica);
            Console.WriteLine("iloczyn={0}", iloczyn);
            Console.WriteLine("iloraz={0}", iloraz);
            Console.ReadKey(true);
        }

    }
}
