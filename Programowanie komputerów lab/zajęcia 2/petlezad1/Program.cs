using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlezad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int i = 1;
            while (i <= 999)
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
