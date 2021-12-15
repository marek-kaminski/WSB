using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uzupełnić program tak aby znajdował również liczbę największą. 
            double a, b, c;
            Console.Write("Podaj liczbę nr 1");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 2");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 3");
            c = Convert.ToDouble(Console.ReadLine());
            //szukamy liczby najmniejszej
            if ((a <= b) && (a <= c))
                Console.WriteLine("liczba {0} jest najmniejsza.", a);
            else if ((b <= a) && (b <= c))
                Console.WriteLine("liczba {0} jest najmniejsza.", b);
            else
                Console.WriteLine("liczba {0} jest najmniejsza.", c);

            if ((a >= b) && (b >= c))
                Console.WriteLine("liczba {0} jest największa.", a);
            else if ((b >= a) && (b >= c))
                Console.WriteLine("liczba {0} jest największa.", b);
            else
                Console.WriteLine("liczba {0} jest największa.", c);
            Console.ReadKey();

        }
    }
}
