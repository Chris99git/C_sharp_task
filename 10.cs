using System;

namespace zadanie_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = { "Ala", "Agata", "Ela", "Gienia", "Ola", "Ela", "Tola", "Ela" };
            Console.WriteLine("Pierwsze wystąpienie ala " + Array.IndexOf(tab, "Ala"));
            Console.WriteLine("Pierwsze wystąpienie ewa " + Array.IndexOf(tab, "Ela"));
            Console.WriteLine("Pierwsze wystąpienie władysław " + Array.IndexOf(tab, "Władysław"));

        }
    }
}
