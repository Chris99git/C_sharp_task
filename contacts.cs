using System;
using System.Collections.Generic;

namespace Zadanie1
{   
    class contact
    {
        public string name { get; set; }
        public string number { get; set; }
    }
    class Program
    {
        static List<contact> contacts = new List<contact>();
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Menu:\n1 - Dodanie nowego kontaktu\n2 - Wyswietlenie wszystkich kontaktow\n3 - Wyszukiwanie za pomoca nazwy\n4 - Wyszukiwanie za pomoca numeru");
            switch (Console.ReadLine())
            {
                case "1":
                    Add();
                    goto Start;
                case "2":
                    ShowAll();
                    goto Start;
                case "3":
                    searchName();
                    goto Start;
                case "4":
                    searchNumber();
                    goto Start;
                default:
                    goto Start;
            }
        }

        static void ShowAll()
        {
            foreach (contact kontakt in contacts)
            {
                Console.WriteLine(kontakt.name);
                Console.WriteLine(kontakt.number+"\n");
            }
        }
        static void Add()
        {
            Console.WriteLine("Podaj imie: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj numer: ");
            string numer = Console.ReadLine();
            contacts.Add(new contact() { name = imie, number = numer });
        }
        static void searchName()
        {
            Console.WriteLine("Podaj imie do wyszukania: ");
            string searchString = Console.ReadLine();
            for(int i=0;i<contacts.Count;i++)
            {
                if (contacts[i].name==searchString)
                {
                    Console.WriteLine(contacts[i].name);
                    Console.WriteLine(contacts[i].number+"\n");
                }
            }
        }
        static void searchNumber()
        {
            Console.WriteLine("Podaj numer do wyszukania: ");
            string searchString = Console.ReadLine();
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].number == searchString)
                {
                    Console.WriteLine(contacts[i].name);
                    Console.WriteLine(contacts[i].number + "\n");
                }
            }
        }
    }
}
