using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetourPoo
{
    public abstract class Vehicule
    {
        public int dureeVieKm;
        public int autonomieKm;
        public string couleur;
        public int anneeDeProduction;
        public string marque;
        public string modele;

        public Vehicule(int dureeVieKm, int autonomieKm, string couleur, int anneeDeProduction, string marque, string modele)
        {
            this.dureeVieKm = dureeVieKm;  
            this.autonomieKm = autonomieKm;
            this.couleur = couleur;
            this.anneeDeProduction = anneeDeProduction;
            this.marque = marque;
            this.modele = modele;
        }
        public abstract void Demarrer();
    }
}
