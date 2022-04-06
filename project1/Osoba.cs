using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Osoba
    {
        private String imie;

        public Osoba(String imie)
        {
            this.imie = imie;
        }
        public override string ToString()
        {
            return this.imie;
        }
    }
}