using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Wektor
    {
        private int liczbaWspolrzednych { get; set; }
        private double[] wspolrzedne { get; set; }

        public Wektor()
        {
        }
        public Wektor(int liczbaWspolrzednych, double[] wspolrzedne)
        {
            this.liczbaWspolrzednych = liczbaWspolrzednych;
            this.wspolrzedne = new double[this.liczbaWspolrzednych];
            for (int i = 0; i < this.liczbaWspolrzednych; i++)
            {
                this.wspolrzedne[i] = wspolrzedne[i];
            }
        }
        public void show()
        {
            foreach (double w in this.wspolrzedne)
            {
                Console.Write(w + ", ");
            }
        }
        public double sum()
        {
            double suma = 0;
            for (int i = 0; i < this.liczbaWspolrzednych; i++)
            {
                suma += this.wspolrzedne[i];
            }
            return suma;
        }

        public Wektor add(Wektor w1)
        {
            Wektor suma = new Wektor(this.liczbaWspolrzednych, new double[this.liczbaWspolrzednych]);
            for (int i = 0; i < this.liczbaWspolrzednych; i++)
            {
                suma.wspolrzedne[i] = this.wspolrzedne[i] + w1.wspolrzedne[i];
            }
            return suma;
        }
    }
}