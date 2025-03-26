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
            int miesiac;
            Console.Write("podaj nr miesiaca: ");
            miesiac = Convert.ToInt32(Console.ReadLine());
            switch (miesiac)
            {
                case 1: Console.WriteLine("miesiac nr {0} to styczen", miesiac); break;
                case 2: Console.WriteLine("miesiac nr {0} to luty", miesiac); break;
                case 3: Console.WriteLine("miesiac nr {0} to marzec", miesiac); break;
                case 4: Console.WriteLine("miesiac nr {0} to kwiecien", miesiac); break;
                case 5: Console.WriteLine("miesiac nr {0} to maj", miesiac); break;
                case 6: Console.WriteLine("miesiac nr {0} to czerwiec", miesiac); break;
                case 7: Console.WriteLine("miesiac nr {0} to lipiec", miesiac); break;
                case 8: Console.WriteLine("miesiac nr {0} to sierpien", miesiac); break;
                case 9: Console.WriteLine("miesiac nr {0} to wrzesien", miesiac); break;
                case 10: Console.WriteLine("miesiac nr {0} to pazdziernik", miesiac); break;
                case 11: Console.WriteLine("miesiac nr {0} to listopad", miesiac); break;
                case 12: Console.WriteLine("miesiac nr {0} to grudzien", miesiac); break;
                default: Console.WriteLine("miesiac nr {0} nie istnieje", miesiac); break;
            }



        }
    }
}
