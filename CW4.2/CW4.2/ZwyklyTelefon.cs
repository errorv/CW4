using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4._2
{
    class ZwyklyTelefon : ITelefon
    {
        public void WybierzNumer(int numer)
        {
            Console.WriteLine("Wybiera nr {0}", numer);
        }

        public void WyslijWiadomosc(int numer, string wiadomosc)
        {
            Console.WriteLine("Napisał: {0} do {1}", wiadomosc, numer);
        }

        public void PokazTyp()
        {
            Console.WriteLine("Telefon typu : gruchot");
        }
    }
}
