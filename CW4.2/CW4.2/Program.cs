using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var zt = new ZwyklyTelefon();
            var sp = new Smartphone(zt);

            zt.WybierzNumer(123456789);
            zt.WyslijWiadomosc(123456789, "HALO!!!");
            sp.ZrobZdjecie();
            sp.RozmowaWideo();
            zt.PokazTyp();
            sp.PokazTyp();
            Console.ReadKey();
        }
    }
}