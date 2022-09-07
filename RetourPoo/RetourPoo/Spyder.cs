using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetourPoo
{
    public class Spyder : Moto
    {
        public Spyder(int dureeVieKm, int tailleReservoir, Moteur moteur, Roue roue, string couleur, string marque, string modele) : base(dureeVieKm, "Spyder", tailleReservoir, moteur, roue, couleur, marque, modele)
        {}
        public override void TournerSerrer()
        {
            Console.WriteLine("Pour faire le tournant serre, vous avez simplement tourner la direction de la Spyder");
        }
    }
}
