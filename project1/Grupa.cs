using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Grupa
    {
        private String nazwa;

        public Grupa(String nazwa)
        {
            this.nazwa = nazwa;
        }

        public override string ToString()
        {
            return this.nazwa.ToString();
        }
    }
}
