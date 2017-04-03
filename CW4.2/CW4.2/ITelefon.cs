using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4._2
{
    interface ITelefon
    {
        void WybierzNumer(int numer);
        void WyslijWiadomosc(int numer, string wiadomosc);
        void PokazTyp();
    }
}
