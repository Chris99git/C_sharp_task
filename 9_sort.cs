using System;

namespace zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sort, posortowane elementy tablicy");
            int[] tab = { 4, 2, 6, 23, 1, 3, 7, 0 };
            Array.Sort(tab);

            //for (int i = 0; i < tab.Length; i++) { Console.Write(tab[i] + " "); }

            foreach (int i in tab)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\npress any key to exit the process...");
            Console.ReadKey();
        }
    }
}
