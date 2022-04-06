using System;
public class Zad2
{
    private int a, b, c, wynik;

    //KONSTRUKTOR
    //public Zad2(int a, int b, int c)
    //{
    //   this.a = a;
    //   this.b = b;
    //   this.c = c;
    //}


    public void czytaj_dane()
    {
        Console.WriteLine("Podaj a");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj b");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj c");
        c = int.Parse(Console.ReadLine());
    }
    public void przetworz_dane()
    {
        wynik = (b * b) - (4 * a * c);
    }
    public void wyswietl_wynik()
    {
        if (wynik == 0)
        {
            Console.WriteLine("Ma jedno rozwiązanie");
        }
        else if (wynik < 0)
        {
            Console.WriteLine("Nie ma rozwiązania");
        }
        else
        {
            Console.WriteLine("Ma dwa rozwiązania");
        }
    }


}
public class Program
{
    static void Main(string[] args)
    {
        Zad2 z = new Zad2();
        z.czytaj_dane();
        z.przetworz_dane();
        z.wyswietl_wynik();
    }
}