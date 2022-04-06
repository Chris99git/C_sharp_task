using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KALKULATOR");

            Console.WriteLine("Podaj proszę 1 liczbę:");
            var number1 = GetInput();

            Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+', '-', '*', '/','^','!','pierwiastek'.");

            var operation = Console.ReadLine();
            Console.WriteLine("Podaj proszę 2 liczbę:");
            var number2 = GetInput();
            var result = 0;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine("wynik dodawania to: " + result);
                    break;
                case "-":
                    result = number1 - number2;
                    Console.WriteLine("wynik odejmowania to: " + result);
                    break;
                case "*":
                    result = number1 * number2;
                    Console.WriteLine("wynik mnozenia to: " + result);
                    break;
                case "/":
                    result = number1 / number2;
                    Console.WriteLine("wynik dzielenia to: " + result);
                    break;
                case "^":
                    double pow = Math.Pow(number1, number2);
                    Console.WriteLine("wynik potegowania to: " + pow);
                    break;
                case "pierwiastek":
                    double a = Math.Sqrt(number1);
                    Console.WriteLine("wynik pierwiasteka 2 stopnia z " + number1 + " to " + a);
                    double b = Math.Sqrt(number2);
                    Console.WriteLine("wynik pierwiasteka 2 stopnia z " + number2 + " to " + b);
                    break;
                case "!":
                    Console.WriteLine(number1 + "! = " + silnia(number1));
                    Console.WriteLine(number2 + "! = " + silnia(number2));
                    break;
                default:
                    throw new Exception("Wybrałeś złą operację!");
            }

        }
        private static int silnia(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * silnia(n - 1);
        }

        private static int GetInput()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
