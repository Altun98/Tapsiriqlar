using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriqlar.Tapsiriq
{
    public static class ExtensionMethods
    {/*
      * arrayin tek elementlerini cap eden ext metod   *
      *ext  metod statik olduqundan onu istifade etdiyimiz yerlerde clasinin instans alinmasina ehtiyyat yoxudr
     * */
        public static void ArrayTek(this int[] _arr)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (!(_arr[i] % 2 == 0))
                {
                    Console.Write(_arr[i] + ",");
                }
            }
        }
    }
}
