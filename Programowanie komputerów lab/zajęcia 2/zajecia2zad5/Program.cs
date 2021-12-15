using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3. Wewnątrz metody Main napisz następujący kod:
a. Zadeklaruj zmienne całkowite: a, b, max. int a, b, max;

b. Pobierz od użytkownika wartości zmiennych a i b: Console.Write("Podaj pierwszą wartość: "); 
a = Convert.ToInt32(Console.ReadLine()); Console.Write("Podaj drugą wartość: "); 
b = Convert.ToInt32(Console.ReadLine());

c. Wyznacz wartość maksymalną z liczb a i b: max = a > b ? a : b;

d. Wypisz obliczoną wartość maksymalną, a następnie zatrzymaj działanie programu: Console.WriteLine("Wartość maksymalna wynosi: ¬{0}.", max); Console.ReadKey();*/


//Zastąpić operator ?: instrukcją if-else nie zmieniając działania programu. 



namespace zajecia2zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, max;
            Console.Write("Podaj pierwszą wartość: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj drugą wartość: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                max = a;
                    }
            else { max = b; }
                
            


            Console.WriteLine("Wartość maksymalna wynosi: ¬{0}.", max); Console.ReadKey(); 

        }
    }
}
