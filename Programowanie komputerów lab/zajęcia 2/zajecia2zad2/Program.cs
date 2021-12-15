using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2zad2
{
    class Program
    {
        /*Uzupełnić program tak aby w nowej linii program wypisywał tekst "Tekst po ponownej zmianie koloru" z poprzednim kolorem tła(czarny) i czcionki(biała). */

        static void Main(string[] args)
        {
            Console.WriteLine("Typ wyliczeniowy ConsoleColor służy do zmiany koloru konsoli");
            //Zmiana koloru tła tekstu
            Console.BackgroundColor = ConsoleColor.Blue;
            //Kolor czcionki
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tekst po zmianie koloru");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Tekst po ponownej zmianie koloru");

            Console.ReadKey();
        }
        
    }
}
