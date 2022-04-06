using System;
using Gazeta;

namespace Kwartalnik
{
    class Kwartalnik : Gazeta.Gazeta
    {
        public Kwartalnik(string isbn, string miesiac, string redaktor)
        {
            this.isbn = isbn;
            this.miesiac = miesiac;
            this.redaktor = redaktor;
        }

        public string isbn { get; set; }
        public string miesiac { get; set; }
        public string redaktor { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public abstract void Typ();

        public virtual void WyswietlDane()
        {
           
            Console.Write(this.nazwa);
            Console.Write(this.wydawnictwo);
            Console.Write(this.rokZalozenia);
            Console.Write(this.rokOstNum);
            Console.Write(this.iloscWydan);
            Console.Write(this.liczbaStron);
            Console.Write(this.cena);
            
        }


    }

    class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}