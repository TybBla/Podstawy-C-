using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień podstawy (r) i wysokosc (h) stożka i wypisujący na ekranie objętość i pole całkowite tego stożka.
            Console.WriteLine("Podaj promień podstawy: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wysokość stożka");
            double h = Convert.ToDouble(Console.ReadLine());
            double polep = Math.PI * r * r;
            double objetosc = 1.0 / 3 * polep * h;
            Console.WriteLine("Objętość wynosi {0}", objetosc);

            double l = Math.Sqrt(r * r + h * h);
            double polec = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("Pole całkowite wynosi {0}", polec);
            Console.ReadKey();
        }
    }
}
