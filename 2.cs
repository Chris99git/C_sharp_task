using System;

namespace zadanie_2
{
    class cw2
    {
        static void Main(string[] args)
        {
            int k = 9;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tab[" + i + "] = " + k);
                k--;
            }
        }
    }
}

/*
//zad2
class cw2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program wyswietla zawartosc tablicy jednowymiarowej 10-elementowej");
        int[] tab = new int[10];
        for (int i = 9; i >= 0; i--)
        {
            tab[i] = i;
            Console.WriteLine("Tab[" + tab[i] + "] = " + tab[i]);
        }
    }

}
}
*/