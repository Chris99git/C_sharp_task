using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program oblicza silnię");
            Console.WriteLine("Podaj liczbę:");
            var x = GetInput();

            if (x<0)
            {
                Console.WriteLine("Podana zła liczba, Błąd. Liczba jest ujemna.");
            }
            else
            {
                //Console.WriteLine(x + "! = " + silnia(x));
                int silnia = 1;
                for (int i = x; i > 1; i--)
                    silnia *= i;

                Console.WriteLine(x + "! = " + silnia);
            }
        }

        private static int silnia(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * silnia(n - 1);
        }

        private static int GetInput()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
