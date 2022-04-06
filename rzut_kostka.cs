using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Symulacja serii rzutów kostką sześcienną");
            Console.WriteLine("Podaj liczbę rzutów: ");
            var x = GetInput();

            for (int i = x; i > 0; i--)
            {
                Random rnd = new Random();
                int liczba = rnd.Next() % 6 + 1;
                Console.WriteLine("     " + liczba);
            }
        }
        private static int GetInput()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
