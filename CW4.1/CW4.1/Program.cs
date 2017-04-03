using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Uczelnia UWM = new Uczelnia(DateTime.Parse("2099/01/01"));
            Uczelnia Stamford = new Uczelnia(DateTime.Parse("2100/01/01"));

            Console.WriteLine(UWM.RekrutujStudentow());
            Console.WriteLine(Stamford.RekrutujStudentow());
            Console.ReadLine();
        }
    }
}
