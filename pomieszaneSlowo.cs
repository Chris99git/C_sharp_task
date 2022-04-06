using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3
{
    class Program
    {
        

        static int Main(string[] args)
        {
            string sekretneSlowo, pomieszaneSlowo, slowoUzytkownika;

            Console.WriteLine("Wpisz słowo");
            sekretneSlowo = Console.ReadLine();
            pomieszaneSlowo = mieszajLitery(sekretneSlowo);

            do
            {
                Console.WriteLine("Co to za słowo?" + pomieszaneSlowo);
                slowoUzytkownika = Console.ReadLine();

                if (slowoUzytkownika == sekretneSlowo)
                {
                    Console.WriteLine("Brawo!");
                }
                else
                {
                    Console.WriteLine("ŹLE!");
                }
            }
            while (slowoUzytkownika != sekretneSlowo);
            return 0;

        }


        private static string mieszajLitery(string slowo)
        {

            Random rnd = new Random();
            string mix = " ";

            while (slowo.Length > 0)
            {
                
                int pozycja = rnd.Next(slowo.Length);  
                mix += slowo[pozycja];
                slowo = slowo.Remove(pozycja, 1);
            }

            return mix;
        }



    }
}
