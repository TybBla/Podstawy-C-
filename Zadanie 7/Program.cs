using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb z uwzględnieniem części całkowitej i reszty z dzielenia.
            Console.WriteLine("Podaj pierwszą liczbę :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę :");
            int b = Convert.ToInt32(Console.ReadLine());
            double iloraz = a / b;
            double reszta = a % b;
            Console.WriteLine("Dzielenie całkowite wynosi {0}, a reszta z dzielenia {1}",iloraz,reszta);
            Console.ReadKey();
        }
    }
}
