using System;

namespace zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            void z7()
            {
                Console.WriteLine("Waga:");
                decimal waga = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Wzrost:");
                decimal wzrost = Convert.ToDecimal(Console.ReadLine());

                
                Console.WriteLine("{0},{1} = {2}", wzrost, waga, wzrost / waga);
                Console.ReadKey();
            }
        }
    }
}
