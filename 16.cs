using System;
class HelloWorld
{
    static void Main()
    {
        //Wektor.ZbudujWektor().Show();
        //Wektor.ZbudujWektor().Show();
        Wektor w1 = new Wektor(2, 4, 10);
        w1.Show();

    }
}

class Wektor
{
    private int wymiar;
    private double[] wspolrzedne;

    public Wektor(int wymiar, double[] wspolrzedne)
    {
        this.wymiar = wymiar;
        this.wspolrzedne = new double[wymiar];
        wspolrzedne.CopyTo(this.wspolrzedne, 0);
        //for (int i = 0; i < this.wymiar; i++)
        //{
        //    this.wspolrzedne[i] = wspolrzedne[i];
        //}
    }

    public Wektor(double[] wspolrzedne)
    {
        //this.wymiar = wspolrzedne.Length;
        this.wspolrzedne = new double[wspolrzedne.Length];
        for (int i = 0; i < this.wspolrzedne.Length; i++)
        {
            this.wspolrzedne[i] = wspolrzedne[i];
        }
    }

    public Wektor(int n, double a, double b)
    {
        this.wymiar = n;
        Random rand = new Random();
        this.wspolrzedne = new double[wymiar];
        for (int i = 0; i < this.wymiar; i++)
        {
            this.wspolrzedne[i] = rand.NextDouble() * (b - a) + a;
            wspolrzedne[i] = Math.Round((rand.NextDouble() * (b - a) + a), 2);
        }

    }

    public static Wektor ZbudujWektor()
    {
        Console.WriteLine("Podaj wymiar nowego wektora");
        int x = int.Parse(Console.ReadLine());
        double[] noweWspolrzedne = new double[x];
        Console.WriteLine("Użytkowniku! Podaj współrzędne nowego wektora");
        for (int i = 0; i < x; i++)
        {
            noweWspolrzedne[i] = double.Parse(Console.ReadLine());
        }
        return new Wektor(noweWspolrzedne);

    }


    public void Show()
    {
        //   Console.WriteLine($"Pokaz {wymiar}");
        foreach (double d in wspolrzedne)
        {
            Console.Write($"{d}, ");
        }
    }

    public double Suma(double[] tab)
    {
        double suma = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            suma += tab[i];
        }
        return suma;
    }

    public Wektor AddWektor(Wektor wektor)
    {
        Wektor suma = new Wektor(this.wymiar, new double[this.wymiar]);
        for (int i = 0; i < this.wymiar; i++)
        {
            suma.wspolrzedne[i] = this.wspolrzedne[i] + wektor.wspolrzedne[i];
        }
        return suma;
    }
}