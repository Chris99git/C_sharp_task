using System;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program oblicza stawke VAT i cene brutto na podstawie ceny netto");
            Console.WriteLine("Podaj cene netto: ");

            double cenaNetto = double.Parse(Console.ReadLine());
            double VAT = 22;
            double stawkaVAT = cenaNetto * (VAT / 100);
            double cenaBrutto = cenaNetto + stawkaVAT;

            Console.WriteLine("Cena brutto wynosi: " + String.Format("{0:N2}", cenaBrutto));
            Console.WriteLine("Obliczona stawka VAT wynosi: " + String.Format("{0:N2}", stawkaVAT));
            Console.ReadKey();
        }
    }
}
