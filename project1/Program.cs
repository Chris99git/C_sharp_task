using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Program
    {
        static void Main()
        {


            Grupa g1 = new Grupa("Grupa nr.1");
            Grupa g2 = new Grupa("Grupa nr.2");
            Grupa g3 = new Grupa("Grupa nr.3");
            Grupa[] grupy = new Grupa[3];
            Osoba o1 = new Osoba("Janina");
            grupy[0] = g1;
            grupy[1] = g2;
            grupy[2] = g3;
            Kurs1 kurs = new Kurs1("Zajęcia", 36, o1, grupy);
            kurs.wyswietl();
            Console.ReadKey();
        }
    }
}
