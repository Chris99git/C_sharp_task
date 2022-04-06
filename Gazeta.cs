using System;
using System.Collections.Generic;

namespace Gazeta
{

    class Gazeta
    {
        public string nazwa { get; set; }
        public decimal cena { get; set; }
        public string wydawnictwo { get; set; }
        public int rokZalozenia { get; set; }
        public int rokOstNum { get; set; }
        public int iloscWydan { get; set; }
        public int liczbaStron { get; set; }

        public Gazeta(string nazwa, decimal cena, string wydawnictwo, int rokZalozenia, int rokOstNum, int iloscWydan, int liczbaStron)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.wydawnictwo = wydawnictwo;
            this.rokZalozenia = rokZalozenia;
            this.rokOstNum = rokOstNum;
            this.iloscWydan = iloscWydan;
            this.liczbaStron = liczbaStron;
        }

        public override void Typ()
        {
        }

    }

    class Program
    {
       

        
    }
}