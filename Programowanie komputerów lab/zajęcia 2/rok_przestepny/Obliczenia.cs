using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rok_przestepny
{
    class Obliczenia
    {
        //CzyPrzestepny(ushort r)

        public static bool CzyPrzestepny(ushort r)
        {
            //return false;
            if ((r % 4 == 0 && r % 100 != 0) || r % 400 == 0) 
            {
                //Console.WriteLine(true);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
