using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriqlar.Tapsiriq
{
    public partial class PartialClass
    {
        //partial clasin 1-ci hissesi sexin bioqrafik melumatlari
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; } = 0;

        public void Print()
        {
            Console.WriteLine($"Adi:{Name} Soyad:{Surname} \nTehsili:{EduType} " +
                $"Tehsil muesisesi:{EduName} \nElaqe nomresi1:{PhoneNumber1}" +
                $"\nElaqe nomresi2:{PhoneNumber2}\nAdresi:{Address} ");
        }
    }
}
