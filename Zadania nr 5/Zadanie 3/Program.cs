using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, S,s1,s2,s3,ABAP, BCBP, ACAP;
            Console.WriteLine("Program sprawdzajacy czy punkt P(x,y) lezy wewnatrz lub nazewanatrz trojkata, lub na jego bokach.");
            Console.WriteLine("Trojkat jest zlozony z tych punktow: A=(-4,-4), B=(4,-2), C=(6,6).");
            Console.WriteLine("wektor AB = (8,2)");
            Console.WriteLine("wektor BC = (2,8)");
            Console.WriteLine("wektor AC = (10,10)");
            
            Console.Write("Podaj x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj y: ");
            y = Convert.ToDouble(Console.ReadLine());
            
            //sprawdzanie czy lezy wewnatrz trojkata
            S=0.5 * Math.Abs((-4) * (-2 - 6) + 4 * (6 - (-4)) + 6 * (-4 - (-2)));
            s1= 0.5 * Math.Abs((x) * (-2 - 6) + 4 * (6 - y) + 6 * (y - (-2)));
            s2= 0.5 * Math.Abs((-4) * (y - 6) + x*(6+4)+6*(-4-y));
            s3= 0.5 * Math.Abs((-4) * (-2 - y) + 4 * (y - (-4)) + x * (-4 - (-2)));

            //sprawdzanie czy lezy na boku trojkata
            ABAP = 8 * (y + 4) - 2 * (x + 4);
            BCBP= 2 * (y + 2) - 8 * (x - 4);
            ACAP = 10 * (y + 4) - 10 * (x + 4);

            if (S == s1 + s2 + s3)
                Console.WriteLine("Punkt P({0},{1}) lezy wewnatrz trojkata",x,y);
            else
                Console.WriteLine("Punkt P({0},{1}) nie lezy wewnatrz trojkata",x,y);

            if (ABAP == 0)
                Console.WriteLine("Punkt P({0},{1}) lezy na boku AB", x, y);
            else if (BCBP==0)
                Console.WriteLine("Punkt P({0},{1}) lezy na boku BC", x, y);
            else if (ACAP == 0)
                Console.WriteLine("Punkt P({0},{1}) lezy na boku AC", x, y);
            else
                Console.WriteLine("Punkt P({0},{1}) nie lezy na zadnym z bokow", x, y);

            Console.ReadKey(true);



        }
    }
}
