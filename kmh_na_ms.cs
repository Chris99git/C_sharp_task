using System;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program oblicza podaną prędkość z km/h na m/s ");
            Console.WriteLine("Podaj predkość: ");
            double predkoscKMH = double.Parse(Console.ReadLine());
            double predkoscMS = predkoscKMH / 3.6;
            Console.WriteLine("Przeliczona predkość wynosi: " + Math.Round(predkoscMS, 2));
            Console.ReadKey();
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace tester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Prędkość:\t");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("\nWynik:\t" + (a / 3.6));
        }
    }
}
*/