using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, del, x1, x2, x;
            Console.WriteLine("Dana jest funckja f(X) = ax^2+bx+c");
            Console.Write("Podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj c: ");
            c = Convert.ToDouble(Console.ReadLine());
            del = b * b - 4 * a * c;
            x1 = (-b - del) / (2 * a);
            x2 = (-b + del) / (2 * a);
            x = -b / (2 * a);
            if (del > 0)
                Console.WriteLine("funkcja ma 2 miejsca zerowe: {0} i {1}", x1, x2);
            else if (del == 0)
                Console.WriteLine("funkcja ma 1 miejsce zerowe: {0}", x);
            else
                Console.WriteLine("Funckja nie ma miejsc zerowych");
            Console.ReadKey(true);





        }
    }
}
