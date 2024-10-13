using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriqlar.Tapsiriq
{
    public static class IntExtMetod24
    {
        // ext metod yazmaq ucun clasimiz statik  olmalidir 
        // eyyni qaydada metodumuzda statik  olmalidir cunki statik clasin icinde statik olmayan nese yerlesdirmek mumkun deyil
        // hemde ki ext metodumuz mutlek statik olmalidir 
        public static void GetOneNumber(this int a)
        {
            string num = a.ToString();
            Console.WriteLine(num[0]);
        }
    }

}
