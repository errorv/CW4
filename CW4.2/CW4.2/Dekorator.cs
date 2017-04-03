using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4._2
{
    class Dekorator : ITelefon
    {
        ITelefon _Itelefon;
        string _Typ;
        public Dekorator(ITelefon _itelefon, string _typ)
        {
            _Itelefon = _itelefon;
            _Typ = _typ;
        }
        public void WybierzNumer(int numer)
        {
            _Itelefon.WybierzNumer(numer);
        }

        public void WyslijWiadomosc(int numer, string wiadomosc)
        {
            _Itelefon.WyslijWiadomosc(numer, wiadomosc);
        }

        public void PokazTyp()
        {
            Console.WriteLine("Telefon typu : {0}", _Typ);
        }
    }
}