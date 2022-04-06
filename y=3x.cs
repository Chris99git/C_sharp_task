using System;

namespace zadanie_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program oblicza wartość funkcji y=3*x dla x zmieniającego się od 0 do 10.");
            Console.WriteLine("for");
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine("x = {0} y = {1}", j, 3 * j);
                }
                Console.ReadKey();

                Console.WriteLine("while");
                int i = 0;
                while (++i <= 10)
                {
                    Console.WriteLine("x = {0} y = {1}", i, 3 * i);
                }
                Console.ReadKey();

                Console.WriteLine("do while");
                i = 0;
                do
                {
                    Console.WriteLine("x = {0} y = {1}", i, 3 * i);
                } while (++i <= 10);
                Console.ReadKey();
            }
        }
    }
