using System;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość tablicy");
            int x = GetInput();
            int[] tab = new int[x];

            for (int i = 0; i < x; i++)
            {
                Random rnd = new Random();
                tab[i] = rnd.Next() % 2;
                Console.WriteLine(tab[i] + " index number: " + i);

            }

            int min;
            int index = 0;
            min = tab[0];
            for (int i = 1; i < x; i++)
                if (min > tab[i])
                {
                    min = tab[i];
                    index = i;
                }
            Console.WriteLine("Najmniejszy element w tablicy to " + min + " index: " + index);
        }
        private static int GetInput()
        {
            return int.Parse(Console.ReadLine());
        }

    }
}
