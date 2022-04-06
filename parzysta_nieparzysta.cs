using System;

namespace zadanie_6
{
    class Program
    {
        private const int V = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe");
            float a = float.Parse(Console.ReadLine());
            if ((float)a % V == 0)
            {
                Console.WriteLine("parzysta");
            }
            else
            {
                Console.WriteLine("nieparzysta");
            }
        }
    }
}
