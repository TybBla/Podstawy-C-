using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby i wypisującyt na ekranie ich sumę, różnicę, iloczyn i iloraz.
            Console.WriteLine("Podaj pierwszą liczbę: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double suma = a + b;
            double roznica = a - b;
            double iloczyn = a * b;
            double iloraz = a / b;
            Console.WriteLine($"Suma wynosi {suma}, Różnica wynosi {roznica}, iloczyn wynosi {iloczyn} i iloraz wynosi {iloraz}");
            Console.ReadKey();
        }
    }
}
