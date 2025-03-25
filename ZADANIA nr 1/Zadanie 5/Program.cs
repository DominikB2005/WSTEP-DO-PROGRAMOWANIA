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
            double r, h, l, Pc, V;
            Console.Write("r=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("h=");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h);
            Pc = Math.PI * r * r + Math.PI * r * l;
            V = (Math.PI * r * r * h)/3;
            Console.WriteLine("Pc={0}", Pc);
            Console.WriteLine("V={0}", V);
            Console.ReadKey(true);



        }
    }
}
