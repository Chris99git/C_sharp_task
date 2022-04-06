using System;

namespace CS_Cw3
{
    class Sprzedaz
    {
        private string nazwaProduktu;
        private int ilosc;
        private decimal cenaSprzedazy;

        public Sprzedaz(string nazwaProduktu, int ilosc, decimal cenaSprzedazy)
        {
            this.nazwaProduktu = nazwaProduktu;
            this.ilosc = ilosc;
            this.cenaSprzedazy = cenaSprzedazy;
        }

        public void Print()
        {
            Console.WriteLine("Produkt: {0}. Cena: {1}. Cena Sprzedazy: {2}", this.nazwaProduktu, this.ilosc, this.cenaSprzedazy);
        }
    }

    class Zamowienie
    {
        private DateTime dataRealizacji;
        private string nazwaKlienta;
        private Sprzedaz[] pozycjaZamowienia;
        private int licznik;

        public Zamowienie(DateTime dataRealizacji, string nazwaKlienta)
        {
            this.dataRealizacji = dataRealizacji;
            this.nazwaKlienta = nazwaKlienta;
            this.pozycjaZamowienia = new Sprzedaz[20];
            this.licznik = 0;
        }

        public void dodajPozycje(Sprzedaz pozycja)
        {
            if (licznik < 20)
            {
                pozycjaZamowienia[licznik] = pozycja;
                licznik++;
            }
        }

        public void dodajPozycje(string nazwaProduktu, int ilosc, decimal cenaSprzedazy)
        {
            if (licznik < 20)
            {
                pozycjaZamowienia[licznik] = new Sprzedaz(nazwaProduktu, ilosc, cenaSprzedazy);
                licznik++;
            }
        }

        public void WypiszZamowienia()
        {
            int i;
            for (i = 0; i < licznik; i++)
            {
                pozycjaZamowienia[i].Print();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Zamowienie z = new Zamowienie(new DateTime(2021, 03, 29), "Klient1");
            z.dodajPozycje("Produkt1", 10, 9.5m);
            z.dodajPozycje("Produkt2", 5, 3.5m);
            z.dodajPozycje("Produkt3", 30, 7.5m);
            z.dodajPozycje("Produkt5", 60, 3.5m);

            Sprzedaz s = new Sprzedaz("Produkt222", 25, 8.5m);
            z.dodajPozycje(s);

            z.WypiszZamowienia();
        }
    }

}