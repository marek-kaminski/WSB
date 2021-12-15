using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjątki
{
    class Program
    {
        static void Main(string[] args)
        {
            double dzielnik, iloraz;
            try
            {
                dzielnik = Convert.ToDouble(Console.ReadLine());
                if (dzielnik == 0)
                    throw new DivideByZeroException("Dzielnik nie może mieć wartość zero!!!");
                iloraz = 10.2 / dzielnik; Console.WriteLine(iloraz);
            }
            catch (FormatException ex) {
                Console.WriteLine("Komunikat wyjatku: {a}", ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Komunikat wyjatku: {0}", ex.Message);
            }

            Console.ReadKey();


        }
    }
}
