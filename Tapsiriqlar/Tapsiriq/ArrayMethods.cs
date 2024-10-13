using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriqlar.Tapsiriq
{
    public class ArrayMethods
    {
        public void ArrMaxMinConvert(int[] _array)
        {
            // xetti arrayin max ve min elementlerinin yerini deyisen metod yazmaq
            // burada iki eded index teyin edirik max ve min ededlerin indexsini daha
            // sonra yer deyisme bu indeksler vasitesile heyata kecrilecek
            int indexMin = 0;
            int indexMax = 0;
            int maxElement = _array[0];
            int minElement = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (maxElement < _array[i])
                {
                    maxElement = _array[i];
                    indexMax = i;
                }
                if (minElement > _array[i])
                {
                    minElement = _array[i];
                    indexMin = i;
                }
            }
            foreach (var item in _array)
            {
                Console.Write(item+",");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
           //yuxarida max ve min elementleri tapdiq ve hemin deyerlerin indekslerinide teyin etdik
           // indi ise bu indeksleri qarsiliqli olaraq deyismekle min ve max ededlerinin yerlerini deyismis olacayiq.
            _array[indexMax] = minElement;
            _array[indexMin] = maxElement;
            foreach (var item in _array)
            {
                Console.Write(item+",");
            }
        }

        public void ArrayBigNumerShow(string[] _arrStr)
        {
            for (int i = 0; i < _arrStr.Length; i++)
            {
               
            }
        }
    }
}
