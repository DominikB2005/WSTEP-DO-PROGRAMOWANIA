using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, potega = 1,i;
            Console.Write("Podaj n aby obliczyc n^n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                potega *= n;
            Console.WriteLine("{0}^{1}={2}", n,n, potega);
            Console.ReadKey(true);
        }
    }
}
