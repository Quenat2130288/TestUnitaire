using RetourPoo;
namespace RetourPooTest
{
    [TestClass]
    public class MotoTest
    {
        string style;
        int tailleReservoir;
        double distanceParcourue;
        int dureeVieKm;
        int autonomieKm;
        string couleur;
        int anneeDeProduction;
        string marque;
        string modele;
        int largeur;
        int pourcentageHauteur;
        int diametreJante;
        int indiceCharge;
        char indiceVitesse;
        int pression;
        string type;
        int taille;
        int nbCylindres;
        int puissanceChevaux;
        double consommationParKm;
        private const string ExpectedUn = "Vrooooom";
        private const string ExpectedDeux = "Pour faire le tournant serre, vous avez du incliner la moto.";
        private const string ExpectedTrois = "Votre Moto a depassee ca duree de vie, elle peut vous lacher a tous moment !!!";
        private const string ExpectedQuatre = "Pour faire le tournant serre, vous avez du incliner la moto.\r\nLe plein d'essence a ete fait :)";

        Roue roue;
        Moteur moteur;
        Moto moto;

        [TestInitialize]
        public void Init()
        {
            style = "a";
            tailleReservoir = 1;
            distanceParcourue = 2;
            dureeVieKm = 3;
            autonomieKm = 4;
            couleur = "b";
            anneeDeProduction = 5;
            marque = "c";
            modele = "d";
            largeur = 6;
            pourcentageHauteur = 7;
            diametreJante = 8;
            indiceCharge = 9;
            indiceVitesse = 'e';
            pression = 10;
            type = "f";
            taille = 11;
            nbCylindres = 12;
            puissanceChevaux = 13;
            consommationParKm = 14;
            this.roue = new Roue(largeur, pourcentageHauteur, diametreJante, indiceCharge, indiceVitesse, pression, type);
            this.moteur = new Moteur(taille, nbCylindres, puissanceChevaux, consommationParKm);
            moto = new Moto(dureeVieKm, style, tailleReservoir, moteur, roue, couleur, marque, modele);
        }
        [TestCleanup]
        public void CleanUp()
        {
            style = " ";
            tailleReservoir = 0;
            distanceParcourue = 0;
            dureeVieKm = 0;
            autonomieKm = 0;
            couleur = " ";
            anneeDeProduction = 0;
            marque = " ";
            modele = " ";
            largeur = 0;
            pourcentageHauteur = 0;
            diametreJante = 0;
            indiceCharge = 0;
            indiceVitesse = ' ';
            pression = 0;
            type = " ";
            taille = 0;
            nbCylindres = 0;
            puissanceChevaux = 0;
            consommationParKm = 0;
        }
        [TestMethod]
        public void Vehicule_valeurDureeVieKmCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<int>(dureeVieKm, moto.dureeVieKm);
        }
        [TestMethod]
        public void Vehicule_valeurStyleCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<string>(style, moto.style);
        }
        [TestMethod]
        public void Vehicule_valeurTailleReservoirCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<int>(tailleReservoir, moto.tailleReservoir);
        }
        [TestMethod]
        public void Vehicule_valeurTailleCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<int>(taille, moto.moteur.taille);
        }
        [TestMethod]
        public void Vehicule_valeurnbCylindresCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<int>(nbCylindres, moto.moteur.nbCylindres);
        }
        [TestMethod]
        public void Vehicule_valeurPuissanceChevauxCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<int>(puissanceChevaux, moto.moteur.puissanceChevaux);
        }
        [TestMethod]
        public void Vehicule_valeurConsommationParKmCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<double>(consommationParKm, moto.moteur.consommationParKm);
        }
        [TestMethod]
        public void Vehicule_valeurLargeurCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<int>(largeur, moto.roue[0].largeur);
        }
        [TestMethod]
        public void Vehicule_valeurPourcentageHauteurCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<int>(pourcentageHauteur, moto.roue[0].pourcentageHauteur);
        }
        [TestMethod]
        public void Vehicule_valeurDiametreJanteCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<int>(diametreJante, moto.roue[0].diametreJante);
        }
        [TestMethod]
        public void Vehicule_valeurIndiceChargeCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<int>(indiceCharge, moto.roue[0].indiceCharge);
        }
        [TestMethod]
        public void Vehicule_valeurindiceVitesseCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<char>(indiceVitesse, moto.roue[0].indiceVitesse);
        }
        [TestMethod]
        public void Vehicule_valeurPressionCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<int>(pression, moto.roue[0].pression);
        }
        [TestMethod]
        public void Vehicule_valeurTypeCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<string>(type, moto.roue[0].type);
        }
        [TestMethod]
        public void Vehicule_valeurCouleurCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<string>(couleur, moto.couleur);
        }
        [TestMethod]
        public void Vehicule_valeurMarqueCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<string>(marque, moto.marque);
        }
        [TestMethod]
        public void Vehicule_valeurModeleCorrecte_VehiculeAvecValeurCorrecte()
        {
            Assert.AreEqual<string>(modele, moto.modele);
        }
        [TestMethod]
        public void Moto_stringDemarrerMoteurCorrecte_AffichageCorrect()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                moteur.DemarrerMoteur();
                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedUn, result);
            }
        }
        [TestMethod]
        public void Moto_ControlePressionDiminue_PressionReduite()
        {
            int pressionComparer = 0;
            roue.pression = pressionComparer;
            moto.DiminuerPression();
            Assert.AreEqual<int>(pressionComparer, roue.pression + 1);
        }
        [TestMethod]
        public void Moto_ajoutDeLaPression_valeurPlusPression()
        {
            int pressionObtenu = 35;
            moto.AjouterPression();
            Assert.AreEqual<int>(pressionObtenu, roue.pression);
        }
        [TestMethod]
        public void Moto_stringTournerSerrerCorrecte_AffichageCorrect()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                moto.TournerSerrer();
                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedDeux, result);
            }
        }
        [TestMethod]
        public void Moto_AjoutUsureCorrect_AffichageEtUsureCorrect()
        {
            moto.distanceParcourue = 10;
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                moto.AjouterUsure();
                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedTrois, result);
            }
        }
        [TestMethod]
        public void Moto_RoulerDistancePositiveParcouru_VerificationDistanceParcouru()
        {
            moto.Rouler(150);
            Assert.AreEqual(150, moto.distanceParcourue);
        }
        [TestMethod]
        public void Moto_RoulerDistanceNegativeParcouru_VerificationDistanceParcouru()
        {
            moto.Rouler(-150);
            Assert.AreEqual(0, moto.distanceParcourue);
        }
        [TestMethod]
        public void Moto_FaireLePleinVerification_VerificationAffichage()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                moto.FaireLePlein();
                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedQuatre, result);
            }
        }
        [TestMethod]
        public void Moto_VerificationAffichageUsure_AffichageUsureCorrect()
        {
            moto.dureeVieKm = 200;
            moto.Rouler(150);
            Assert.AreEqual(150, moto.distanceParcourue);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                moto.AjouterUsure();
                var result = sw.ToString().Trim();
                Assert.AreEqual("", result);
            }
        }
    }
}