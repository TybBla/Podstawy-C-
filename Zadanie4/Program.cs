using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej największej z tych liczb.
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj czwartą liczbę: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj piątą liczbę: ");
            int e = int.Parse(Console.ReadLine());
            int min;
            int max;
            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
                max = a;
            else if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
                max = b;
            else if ((c >= b) && (c >= a) && (c >= d) && (c >= e))
                max = c;
            else if ((d >= b) && (d >= c) && (d >= a) && (d >= e))
                max = d;
            else 
                max = e;
            Console.WriteLine("Najwieksza liczba - {0}", max);
            if ((a <= b) && (a <= c) && (a <= d) && (a <= e))
                min = a;
            else if ((b <= a) && (b <= c) && (b <= d) && (b <= e))
                min = b;
            else if ((c <= a) && (c <= b) && (c <= d) && (c <= e))
                min = c;
            else if ((d <= a) && (d <= c) && (d <= b) && (d <= e))
                min = d;
            else 
                min = e;
            Console.WriteLine("Najmniejsza liczba - {0}", min);
            Console.ReadKey();

        }
    }
}
