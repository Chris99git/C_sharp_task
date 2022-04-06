using System; 
namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj ilość danych min 5");
            int x;
            x = int.Parse(Console.ReadLine());
            int[]dane = new int[x];
            if (x>4)
            {
                for (int i = 0; i < dane.Length; i++)
                {
                    Console.WriteLine($"Podaj {i + 1} dane: ");
                    dane[i] = int.Parse(Console.ReadLine());
                }

                foreach (var item in dane)
                {
                    Console.Write($"{"y= " + item * 3},");
                }
            }
            else
            {
                Console.WriteLine("podaj większą liczbę danych");
            }
        }
    }
}

