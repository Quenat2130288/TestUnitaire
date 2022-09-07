using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetourPoo
{
    public class Roue
    {
        public int largeur;
        public int pourcentageHauteur;
        public int diametreJante;
        public int indiceCharge;
        public char indiceVitesse;
        public int pression;
        public string type;

        public Roue(int largeur, int poucentageHauteur, int diametreJante, int indiceCharge, char indiceVitesse, int pression, string type)
        {
            this.largeur = largeur;
            this.pourcentageHauteur = poucentageHauteur;
            this.diametreJante = diametreJante;
            this.indiceCharge = indiceCharge;
            this.indiceVitesse = indiceVitesse;
            this.pression = pression;
            this.type = type;
        }
        public Roue(Roue roue)
        {
            largeur = roue.largeur;
            pourcentageHauteur = roue.pourcentageHauteur;
            diametreJante = roue.diametreJante;
            indiceCharge = roue.indiceCharge;
            indiceVitesse = roue.indiceVitesse;
            pression = roue.pression;
            type = roue.type;
        }
        public void GonflerPneu(int x)
        {
            pression += x;
            Console.WriteLine("Le pneu est regonfler");
        }
    }
}
