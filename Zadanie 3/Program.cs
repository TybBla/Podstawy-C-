using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb.
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę: ");
            int c = int.Parse(Console.ReadLine());
            int max;
            int min;
            if ((a >= b) && (a >= c))
                max = a;
            else if ((b >= a) && (b >= c))
                max = b;
            else
                max = c;

            if ((a <= b) && (a <= c))
                min = a;
            else if ((b <= a) && (b <= c))
                min = b;
            else
                min = c;
            Console.WriteLine("Liczba {0} jest największa.", max);
            Console.WriteLine("Liczba {0} jest najmniejsza.", min);
            Console.ReadKey();
        }
    }
}
