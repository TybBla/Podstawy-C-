using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, ujemna, czy też równa zero.
            Console.WriteLine("podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Liczba {0} jest dodatnia.", a);
            else if (a == 0)
                Console.WriteLine("Liczba {0} jest równa zero", a);
            else
                Console.WriteLine("Liczba {0} jest ujemna.", a);
            Console.ReadKey();

        }
    }
}
