using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2zad1
{

class Program
    {
        //Defincja typu wyliczeniowego
        enum PoryRoku : byte { Wiosna, Lato, Jesien, Zima }

        static void Main(string[] args)
        {
            PoryRoku sezon;
            Console.WriteLine("Podaj swoją ulubioną porę roku:");

            Console.WriteLine("\t0 - Wiosna\n\t1 - Lato\n\t2 - Jesień\n\t3 - Zima");
            int i = Convert.ToInt32(Console.ReadLine());
            sezon = (PoryRoku)i;    //Konieczna konwersja
            Console.WriteLine("Twoja ulubiona pora roku to {0}", sezon);

            Console.WriteLine("Podaj najmniej lubianą porę roku:");
            int j = Convert.ToInt32(Console.ReadLine());
            sezon = (PoryRoku)j;    //Konieczna konwersja
            Console.WriteLine("Twoja najmniej lubiana pora roku to {0}", sezon);

            Console.ReadKey();
        }
    }

}
