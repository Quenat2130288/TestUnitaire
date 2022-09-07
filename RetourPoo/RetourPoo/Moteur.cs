using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetourPoo
{
    public class Moteur
    {
        public int taille;
        public int nbCylindres;
        public int puissanceChevaux;
        public double consommationParKm;

        public Moteur(int taille, int nbCylindres, int puissanceChevaux, double consommationParKm)
        {
            this.taille = taille;
            this.nbCylindres = nbCylindres;
            this.puissanceChevaux = puissanceChevaux;
            this.consommationParKm = consommationParKm;
        }

        public void DemarrerMoteur()
        {
            Console.WriteLine("Vrooooom");
        }
    }
}
