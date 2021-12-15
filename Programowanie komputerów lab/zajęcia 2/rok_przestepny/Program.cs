using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rok_przestepny
{
    class Program
    {
        static void Main(string[] args)
        {
            //program zwraca true jak rok jest przestępny
            // czyli dzieli sie przez 4 oraz niepodzielny przez 100 chyba że dzieli się przez 400
            //Console.WriteLine("Podaj rok: ");
            //ushort rok = Convert.ToUInt16(Console.ReadLine());



            Console.WriteLine(Obliczenia.CzyPrzestepny(2020));
            Console.WriteLine(Obliczenia.CzyPrzestepny(2021));
            Console.WriteLine(Obliczenia.CzyPrzestepny(2000));
            Console.WriteLine(Obliczenia.CzyPrzestepny(1900));
            Console.ReadKey();

        }
    }
}
