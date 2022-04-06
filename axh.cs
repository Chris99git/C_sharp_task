using System;
public class zad1
{
    private double a, h, wynik;
    public void czytaj_dane()
    {
        Console.WriteLine("Podaj a i pozniej wysokosc : ");
        this.a = double.Parse(Console.ReadLine());
        this.h = double.Parse(Console.ReadLine());
    }
    public void przetworz_dane()
    {
        this.wynik = (this.a * this.h) / 2;
    }
    public void wyswietl_wynik()
    {
        Console.WriteLine("Wynik to: " + this.wynik);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        zad1 z = new zad1();
        z.czytaj_dane();
        z.przetworz_dane();
        z.wyswietl_wynik();
    }
}