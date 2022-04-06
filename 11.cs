using System;

namespace dodatek_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random zmienna = new Random(); // Utworzenie zmiennej, ktora bedzie losować. 
            int[] tab = new int[200]; //Deklaracja tablicy
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = zmienna.Next(1, 200); //Losowanie i przypisanie wylosowanej liczby do miejsca w tablicy
            }
            double suma = 0;
            foreach (int i in tab)
            {
                suma = suma + i; //obliczanie sumy wartosci z tablicy.
            }
            Console.WriteLine("Suma to\t" + suma);
            Console.ReadKey();
        }
    }
}