using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriqlar.Tapsiriq
{
    public static class Halper
    {
        public static void IntConvertString(this int num)
        {
            string revNum = num.ToString();
            for (int i = revNum.Length-1;i >=0; i--)
            {
                Console.Write(revNum[i]);
            }
        }
    }
}
