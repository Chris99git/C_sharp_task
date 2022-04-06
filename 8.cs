using System;

namespace zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Reverse, tablica po odwróceniu: ");
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Array.Reverse(tab);
            /*
            for (int i = 0; i < tab.Length; i++) { Console.Write(tab[i] + " "); }
            */

            foreach (int i in tab)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\npress any key to exit the process...");
            Console.ReadKey();
        }
    }
}
