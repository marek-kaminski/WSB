using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlezad4
{
    /*Napisz program pobierający od użytkownika dwie liczby całkowite. 
    Program powinien wypisać parzyste liczby znajdujące się pomiędzy(przedział domknięty) podanymi wartościami.
    
    Oto wydruk dla a = 3 i b = 6:
    4 6

    Oto wydruk dla a = 4 i b = 7:
    4 6

    Oto wydruk dla a = -3 i b = 3:
    -2 0 2*/

    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Proszę podaj liczbę a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Proszę podaj liczbę b: ");
            b = Convert.ToInt32(Console.ReadLine());



            Console.Write("Liczby parzyste znajdujące się pomiędzy podanymi wartościami to: ");
            if (a > b )
            {
                int c = a;
                a = b;
                b = c;

            }
            while (a % 2 == 0 && a <= b) 
            {

                
                Console.Write("{0}, ", a);
                a = a+2;


            }





            Console.ReadKey();
        }
    }
}
