using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlezad3
{
    //Zmienić poprzedni program tak, żeby to użytkownik podawał wartość n która zastąpi stałą 10.
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Proszę podaj liczbę powrórzeń: ");
            double n;
            n = Convert.ToDouble(Console.ReadLine());
            int s = 0;
            int i = 1;
            while (i < n)
            {

                s += i;
                Console.Write("{0} + ", i);
                i++;
            }

            s += i;
            Console.Write("{0} ", i);
            Console.WriteLine("= {0}", s);

            Console.ReadKey();
        }
    }
}
