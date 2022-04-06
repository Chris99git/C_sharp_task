using System;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dane = new int[10];
            for (int i = 0; i <= dane.Length - 1; i++)
            {
                dane[i] = i;
                Console.WriteLine("dane[" + i + "] = " + i);
            }
        }
    }
}