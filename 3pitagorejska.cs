using System;

namespace _4
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Sprawdzanie trójki pitagorejskiej");

            Console.WriteLine("Podaj 1 liczbę:");
            var a = GetInput();

            Console.WriteLine("Podaj proszę 2 liczbę:");
            var b = GetInput();

            Console.WriteLine("Podaj proszę 3 liczbę:");
            var c = GetInput();

            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("Liczby stanowią trójke pitagorejska");
            else
                Console.WriteLine("To nie jest trójka pitagorejska");
            return 0;

        }
        private static int GetInput()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
