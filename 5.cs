using System;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaElementow = 0;
            int suma = 0;
            Console.WriteLine("Podaj ilość elementów tablicy:");
            liczbaElementow = int.Parse(Console.ReadLine());
            int[] tablica = new int[liczbaElementow];


            for (int i = 0; i < liczbaElementow; i++)
            {

                Console.WriteLine("Podaj element " + (i + 1) + " :");
                int liczba = int.Parse(Console.ReadLine());
                suma += liczba;

            }
            Console.WriteLine("Suma to: " + suma);

        }
    }
}
