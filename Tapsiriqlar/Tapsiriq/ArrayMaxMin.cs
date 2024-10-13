using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriqlar.Tapsiriq
{
    public static class ArrayMaxMin
    {
        public static int[] GetMaxNin(out int max, out int min)
        {
            /* array qaytaran ve hemin arrayin max ve min elementlerini out ile geri qaytaran metod yazmaq
             * ilk once 10 elementli bir int array yaradiriq daha sonra random ile hemin arrayin icini doldururuq daha 
             * sonra ise bir  dovur operatoru ile hemin arrayin max ve minimum deyerlerini elde ederek 
             * out ile verilmis min ve max deyisenlerine menimsedirik.
             */
            int[] _arr = new int[10];
            Random rd = new Random();
            for (int i = 0; i < _arr.Length; i++)
            {
               _arr[i] = rd.Next(1,25);
            }
            max=_arr[0];
            min = _arr[0];
            for (int i = 0; i < _arr.Length; i++)
            {
                if (max < _arr[i])
                {
                    max = _arr[i];
                }
                if (min > _arr[i])
                {
                    min = _arr[i];
                }
            }
            return _arr;
        }
    }
}
