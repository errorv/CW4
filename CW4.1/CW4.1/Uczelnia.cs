using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4._1
{
    class Uczelnia
    {
        private static Uczelnia _Instance;
        private DateTime _dataRekrutacji;
        public Uczelnia(DateTime datarekrutacji)
        {
            _dataRekrutacji = datarekrutacji;
        }
        public static Uczelnia Instance(DateTime dataRekrutacji)
        {
            if (_Instance == null)
            {
                _Instance = new Uczelnia(dataRekrutacji);

                return _Instance;
            }
            return _Instance;

        }
        public DateTime RekrutujStudentow()
        {
            return _dataRekrutacji;
        }
    }
}