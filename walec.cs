using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pole i objetosc walca");

            Console.WriteLine("Podaj promień:");
            double r = GetInput();

            Console.WriteLine("Podaj wysokość:");
            double h = GetInput();

            if (r <= 0 | h <= 0)
            {
                Console.WriteLine("błędny promień lub wysokość, musi być to liczba większa od 0");
            }
            else
            {
                double pp = Math.PI * (r * r);
                double pb = 2 * (Math.PI * r * h);
                Console.WriteLine("pole całokowite walca to: " + ((2 * pp) + pb));
                Console.WriteLine("objętość walca to: " + Math.PI * (r * r) * h);
            }
        }

        private static int GetInput()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}