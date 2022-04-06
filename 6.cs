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
            const int sum = 5;
            int[,] macierz = new int[sum, sum];


            for (int i = 0; i < sum; i++)
            {
                macierz[i, i] = 1;
            }

            for (int i = 0; i < sum; i++)
            {
                for (int j = 0; j < sum; j++)
                {
                    Console.Write(macierz[i, j]);
                }
                Console.Write("\n");
            }
            Console.Write("Suma wynosi:\t" + sum);
        }
    }
}

/*
 *     int[,] tab = new int[10, 10];
             for (int i = 0; i < 10; i++)
             {
                 for (int j = 0; j < 10; j++)
                 {
                     if (i == j)
                     {
                         tab[i, j] = 1;
                     }
                 }
             }
             int suma = 0;
             for (int i = 0; i < 10; i++)
             {
                 for (int j = 0; j < 10; j++)
                 {
                     suma += tab[i, j];
                     Console.Write(tab[i, j] + " ");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine("Suma wyroznionych elementow w tablicy wynosi " + suma+ ".");
             Console.ReadKey();
 */