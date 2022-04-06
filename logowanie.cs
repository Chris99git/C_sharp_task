using System;
using System.Globalization;
using System.Diagnostics;
using System.Threading;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Time();
            Account(); 
        }

        private static void Account()
        {
            string password = "qwerty";
            string haslo;
            int i = 0;

            Console.WriteLine("Przyznanie dostępu wyłącznie użytkownikowi o nazwie admin, brak innej możlowości");
            do
            {
                Console.WriteLine("Podaj hasło: ");

                haslo = Console.ReadLine();

                if (haslo != password)
                {
                    i++;
                    Console.WriteLine("Błędne hasło spróbój ponownie, pozostało prób " + (3 - i));
                }
                else
                {
                    break;
                }
            }
            while (i < 3);
            if (i == 3)
            {
                Console.WriteLine("Osiągnięto maksymalną liczbę prób. Dostęp zablokowany. Następne podejście możliwe za 30s ");
                Timer();
                Console.WriteLine(" ");
                Account();
            }
            else
            {
                Console.WriteLine("Hasło poprawne. To co dzisiaj robimy?");
            }
        }

        private static void Time()
        {
            DateTime localDate = DateTime.Now;
            String[] cultureNames = { "pl-PL" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("   Local date and time: {0}, {1:G}",
                                  localDate.ToString(culture), localDate.Kind);
                Console.WriteLine(" ");

            }
        }

        public static void Timer()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(30000);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
        }
    }
}
