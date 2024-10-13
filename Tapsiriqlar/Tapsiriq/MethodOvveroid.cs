using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriqlar.Tapsiriq
{
    public class MethodOvveroid
    {
        //fiqurlarin sahesi ucun overload metodlar yazmaq
        // burada metodlarin overloid edilmesi metodun parametresinin tipine ve sayina gore olur.
        public void Sahe(int a)
        {
            //kvadratin sahesini hesablama a*a
            Console.WriteLine(a * a);
        }
        public void Sahe(int a, int b)
        {
            //Duzbucaqlinin sahesinin hesablanmasi 2*(a+b)
            Console.WriteLine(2 * (a + b));
        }

    }
}
