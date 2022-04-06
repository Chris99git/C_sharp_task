using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Kurs1
    {
        private String nazwa;
        private double liczbaGodzin;
        private Osoba osoba;
        private Grupa[] grupy;

        public Kurs1(String nazwa, double liczbaGodzin, Osoba osoba, Grupa[] grupy)
        {
            this.nazwa = nazwa;
            this.liczbaGodzin = liczbaGodzin;
            this.osoba = osoba;
            this.grupy = grupy;
        }
        public void wyswietl()
        {
            Console.WriteLine("Nazwa: " + this.nazwa);
            Console.WriteLine("Liczba godzin: " + this.liczbaGodzin);
            Console.WriteLine("Prowadzący: " + this.osoba);
            Console.WriteLine("Grupy ćwiczeniowe: ");
            grupy.ToList().ForEach(i => Console.WriteLine(i.ToString()));
        }
    }
}
