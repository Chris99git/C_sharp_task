using System;

namespace zadanie_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y:");
            int y = int.Parse(Console.ReadLine());

            string sX;
            int i, j;
            int len = x > y ? x - y : y - x;
            int[,] tab = new int[len + x + 1, len + x + 1];

            for (i = x; i <= (len + x); i++)
            {
                for (j = x; j <= (len + x); j++)
                {
                    if (i == x)
                        tab[i, j] = j;
                    else if (j == x)
                        tab[i, j] = i;
                    else
                        tab[i, j] = i * j;

                    if (y < 20)
                        sX = tab[i, j].ToString().PadRight(4, ' ');
                    else
                        sX = tab[i, j].ToString().PadRight(6, ' ');

                    Console.Write(sX);
                }
                Console.WriteLine();
            }
        }
    }
}
