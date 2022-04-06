using System;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] uczestnicyWycieczki = { 25, 23, 29, 35, 41 };
            int ilosc, maksymalnyWiek, minimalnyWiek;
            ilosc = 0;
            maksymalnyWiek = 0;
            minimalnyWiek = 100;

            for (int i = 0; i < 5; i++)
            {
                ilosc += uczestnicyWycieczki[i];
                if (uczestnicyWycieczki[i] > maksymalnyWiek)
                {
                    maksymalnyWiek = uczestnicyWycieczki[i];
                }
                if (uczestnicyWycieczki[i] < minimalnyWiek)
                {
                    minimalnyWiek = uczestnicyWycieczki[i];
                }

            }
            Console.WriteLine("Maksymalny wiek:" + maksymalnyWiek);
            Console.WriteLine("Minimalny wiek: " + minimalnyWiek);
            Console.WriteLine("Suma: " + ilosc);
        }
    }
}

/*
Zadanie 3 na operatorze trójargumentowym:
static void Main(string[] args)
{
    int[] uczestnicyWycieczki = { 26, 34, 23, 54, 31 };
    int suma = 0, najmlodszy = 200, najstarszy = 0;
    foreach (int u in uczestnicyWycieczki)
    {
        suma += u;
        najmlodszy = (u < najmlodszy) ? u : najmlodszy;
        najstarszy = (u > najstarszy) ? u : najstarszy;
    }
    Console.WriteLine("Suma wieku: {0}", suma);
    Console.WriteLine("Najstarszy: {0}", najstarszy);
    Console.WriteLine("Najmładszy: {0}", najmlodszy);
}
*/