using System;

namespace zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę imion które chcesz wpisać");  
            
            var x = int.Parse(Console.ReadLine());
            var name = new string[x];

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"Podaj {i+1} imię: ");
                name[i] = Console.ReadLine();
            }

            foreach (var item in name)
            {
                Console.Write($"{item},");
            }
        }
    }
}

/*
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar = 0;
            Console.WriteLine("Ile imion chcesz wpisać?");
            rozmiar = int.Parse(Console.ReadLine());
            string[] imiona = new string[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine("Podaj imię osoby: {0}", (i + 1));
                imiona[i] = Console.ReadLine();
            }
            for (int i = 0; i < rozmiar; i++)
            {
                Console.Write("{0}, ", imiona[i]);
            }
        }
    }
}

*/