using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisac program wczytujacvy boki prostokata, i wypisujacy na ekranie jego pole i obwod.
            double a;
            double b;
            double obwod;
            Console.WriteLine("podaj bok a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj bok b: ");
            b = Convert.ToDouble(Console.ReadLine());
            obwod = a + a + b + b;
            double pole = a * b;
            Console.WriteLine("Obwód = {0}",a + a + b + b);
            Console.WriteLine("Obwód = {0}", obwod);
            Console.WriteLine("Pole = {0}", a*b);
            Console.WriteLine("Pole = {0}", pole);

            Console.ReadKey();
        }
    }
}
