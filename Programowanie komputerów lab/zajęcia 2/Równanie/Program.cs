using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Równanie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Użytkownik podaje wartości całkowite a,b,c
            // równania kwadratowego ax^2 + bx + c = 0
            // Program oblicza ile jest rozwiązań oraz
            // wypisuje te rozwiązania
            // użyć składni try-catch do zapewnienia obsługi danych wejsciowych

            double a, b, c, x1, x2, delta;
            try
            {
                Console.Write("Podaj wartość parametru a: ");
                a = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                { 
                    throw new Exception("Parametr a powinien być ¬różny od zera");
                }
                Console.Write("Podaj wartość parametru b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj wartość parametru c: ");
                c = Convert.ToDouble(Console.ReadLine());
                delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a); x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Równanie ma dwa ¬pierwiastki:");
                    Console.WriteLine("\tx1 = {0}", x1);
                    Console.WriteLine("\tx2 = {0}", x2);
                    else {
                        if (delta == 0)
                        {
                            x1 = -b / (2 * a); Console.WriteLine("Równanie ma jeden ¬pierwiastek rzeczywisty:");
                            Console.WriteLine("\tx1 = {0}", x1);
                        }
                   
                         else { Console.WriteLine("Równanie nie ma ¬pierwiastków rzeczywistych."); }
                }
            catch
            {
                
            }
            Console.ReadKey();
        }
    }
}