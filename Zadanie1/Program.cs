using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to liczba parzysta, czy też nieparzysta.
            Console.WriteLine("Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Liczba jest parzysta.");
            else
                Console.WriteLine("Liczba jest nieparzysta.");
            Console.ReadKey();
        }
    }
}
