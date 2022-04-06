using System;

namespace zadanie_1
{
    class main
    {
        static void Main(string[] args)
        {
            zd1 zd1 = new zd1();
            zd1.do_zd();
            //zd2 zd2 = new zd2();
            //zd2.do_zd();
        }
    }
/*
    class zd1
    {
        public zd1() { }

        public void do_zd()
        {
            trojkat t = new trojkat();
            t.wczytaj_dane();
            t.przetworz_dane();
            t.wyswietl_dane();
        }
    }

    class trojkat
    {
        private double a;
        private double h;
        private double wynik;
        public trojkat() { }

        public void wczytaj_dane()
        {
            Console.WriteLine("Podaj a:");
            this.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj h:");
            this.h = int.Parse(Console.ReadLine());
        }

        public void przetworz_dane()
        {
            this.wynik = (this.a * this.h) / 2;
        }

        public void wyswietl_dane()
        {
            Console.WriteLine("Trojkat o boku {0} i wysokosci {1} ma pole = {2}", this.a, this.h, this.wynik);
        }
    }
    */


    /*class zd1
    {
        public zd1() { }

        public void do_zd()
        {
            trangle t = new trangle();
            t.Read_Data();
            t.Process_Data();
            t.Show_Data();
        }

    }

    class trangle
    {
        private double a;
        private double h;
        private double area;
        public trangle() { }

        public void Read_Data()
        {
            Console.WriteLine("Enter a:");
            this.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter h:");
            this.h = int.Parse(Console.ReadLine());
        }
        public void Process_Data()
        {
            this.area = (a * h) / 2;
        }
        public void Show_Data()
        {
            Console.WriteLine("A = {0}  H = {1}  Area = {2}", a, h, area);
        }

    }

    class zd2
    {
        public zd2() { }

        public void do_zd()
        {
            Sqrt t = new Sqrt();
            t.Read_Data();
            t.Process_Data();
            t.Show_Data();
        }

    }

    class Sqrt
    {
        private int a;
        private int b;
        private int c;
        private double delta;
        private double x1;
        private double x2;
        public Sqrt() { }

        public void Read_Data()
        {
            Console.WriteLine("Enter a:");
            this.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            this.b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            this.c = int.Parse(Console.ReadLine());
        }
        public void Process_Data()
        {
            delta = (b ^ 2) - (4  a  c);
            
            if(delta >)

            this.x1 = (-b - (Math.Sqrt(delta)) / (2 * a));
            this.x2 = (-b + (Math.Sqrt(delta)) / (2 * a));
        }
        public void Show_Data()
        {
            Console.WriteLine("x1 = {0}  x2 = {1}", x1, x2);
        }

    }*/


    Zadanie2 zadanie2 = new Zadanie2();
    zadanie2.czytaj_dane();
            zadanie2.przetworz_dane();
            zadanie2.wyswietl_wynik();
class Zadanie2
    {
        private int a;
        private int b;
        private int c;
        private int wynik;
        public Zadanie2() { }

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
            wynik = (b  b) -(4  a* c);
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