using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetourPoo
{
    public class Moto: Vehicule
    {
        public Moteur moteur;
        public Roue[] roue = new Roue[2];
        public string style;
        public int tailleReservoir;
        public double distanceParcourue;

        public Moto(int dureeVieKm, string style, int tailleReservoir, Moteur moteur, Roue roue, string couleur, string marque, string modele) : base(dureeVieKm, tailleReservoir, couleur, 2022, marque, modele)
        {
            this.roue[0] = roue;
            this.roue[1] = new Roue(roue);
            this.moteur = moteur;
            this.style = style;
            this.tailleReservoir = tailleReservoir;
            this.couleur = couleur;
        }

        public override void Demarrer()
        {
            ConsoleColor consoleColor = ConsoleColor.White;
            try
            {
                consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), base.couleur, true);
            }
            catch (Exception)
            {
                //Invalid color
            }
            Console.ForegroundColor = consoleColor;
            moteur.DemarrerMoteur();
        }
        public void Rouler(int distanceTotal)
        {
            while(distanceTotal > 0)
            {
                distanceTotal -= tailleReservoir;
                Console.WriteLine("Vous avez rouler "+ tailleReservoir +"km. Vous devez faire le plein avant de continuer le voyage.");
                DiminuerPression();
                FaireLePlein();
                distanceParcourue += tailleReservoir;
                Console.WriteLine("Il reste " + distanceTotal + "km a parcourir\n");
                if(dureeVieKm <= distanceParcourue)
                {
                    AjouterUsure();
                }

                if (roue[0].pression < 25)
                {
                    Console.WriteLine("Il faut vous arretez pour regonfler vos deux roues\n Vous avez regonfler vos roue !\n");
                    AjouterPression();
                }
            }
            if (distanceTotal < tailleReservoir)
            {
                Console.WriteLine("Votre voyage est terminer\n");
            }
        }
        public void DiminuerPression()
        {
            foreach(Roue roue in roue)
            {
                roue.pression -= 1;
            }
        }
        public void AjouterPression()
        {
            foreach (Roue roue in roue)
            {
                roue.pression = 35;
            }
        }
        public void FaireLePlein()
        {
            TournerSerrer();
            autonomieKm = 30;
            Console.WriteLine("Le plein d'essence a ete fait :)");
        }
        public virtual void TournerSerrer()
        {
            Console.WriteLine("Pour faire le tournant serre, vous avez du incliner la moto.");
        }
        public void AjouterUsure()
        {
            if(distanceParcourue >= dureeVieKm)
            {
                Console.WriteLine("Votre Moto a depassee ca duree de vie, elle peut vous lacher a tous moment !!!");
            }
        }
    }
}
