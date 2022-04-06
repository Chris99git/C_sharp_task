using System;

namespace dodatek_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dane = new int[50];
            int sumaP = 0, sumaNp = 0;

            for (int i = 0; i < dane.Length; i++)
            {
                dane[i] = i + 1;
            }

            foreach (var e in dane)
            {
                if (e % 2 == 0)
                {
                    sumaP += e;
                }
                else
                {
                    sumaNp += e;
                }
            }
            Console.WriteLine("Suma liczba nieparzystych w przedziale 1 - 50: {0}", sumaNp);
            Console.WriteLine("Suma liczba parzystych w przedziale 1 - 50: {0}", sumaP);
        }
    }
}
