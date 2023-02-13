using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepteremProjekt
{
    internal class Gepterem
    {
        readonly int[,] ertekeles;
        readonly int hely;
        readonly string nev;
        readonly int sordarab;

        public Gepterem(string nev, int sordarab, int hely, int[,] ertekeles)
        {
            this.nev = nev;
            this.sordarab = sordarab;
            this.hely = hely;
            this.ertekeles = ertekeles;
        }
        public int[,] Ertekeles => ertekeles;

        public int Hely => hely;

        public string Nev => nev;

        public int Sordarab => sordarab;
        public double Atlag()
        {
            double sum = 0;
            int db = 0;
            for (int i = 0; i < sordarab; i++)
            {
                for (int j = 0; j < hely; j++)
                {
                    if (ertekeles[i, j] > 0)
                    {
                        sum += ertekeles[i, j];
                        db++;
                    }
                }
            }
            return sum / db;
        }
    }
}
