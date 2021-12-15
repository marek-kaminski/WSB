using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlezad2
{
    class Program
    {
        //Użyć pętli for zamiast while w poprzednim zadaniu.
        static void Main(string[] args)
        {
            int s = 0;
            Console.Write("1 ");
            for (int i = 1; i<9;i++)
            {

                s += i;
                Console.Write("+ {0} ", i);
                i++;
            }

            //s += i;
            //Console.Write("{0} ", i);
            Console.WriteLine("= {0}", s);

            Console.ReadKey();



        }
    }
}
