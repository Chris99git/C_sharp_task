using System;

namespace zadanie_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe 1");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe 2");
            int b = int.Parse(Console.ReadLine());

            int max = a > b ? a : b;

            Console.WriteLine("max: "+ max);
        

        }
    }
}
