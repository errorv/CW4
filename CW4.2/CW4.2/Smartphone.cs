using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4._2
{
    class Smartphone : Dekorator
    {
        private string rt;
        public Smartphone(ZwyklyTelefon zwyklytelefon, string rodzajtelefonu = "smartphone") : base(zwyklytelefon, rodzajtelefonu)
        {
            this.rt = rodzajtelefonu;
        }

        public void ZrobZdjecie()
        {
            Console.WriteLine("Zdjęcie wykonane");
        }
        public void RozmowaWideo()
        {
            Console.WriteLine("Rozpoczęto rozmowę video");
        }
    }
}
