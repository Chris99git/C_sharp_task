using System;

namespace zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] macierz = new double[10, 10];
            double suma1 = 0, suma2 = 0;
            Console.WriteLine("Program wyświetla zawartość tablicy dwuwymiarowej 10x10");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == 0)
                    {
                        macierz[i, j] = i;
                        suma1 += macierz[i, j];
                    }
                    else if (j == 1)
                    {
                        macierz[i, j] = macierz[i, j - 1] * macierz[i, j - 1];
                        suma2 += macierz[i, j];
                    }
                    else
                    {
                        macierz[i, j] = 0;
                    }
                    Console.Write(macierz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Suma liczb znajdujących się w pierwszej kolumnie = " + suma1);
            Console.WriteLine("Suma liczb znajdujących się w drugiej kolumnie = " + suma2);
            Console.ReadKey();
        }
    }
}
