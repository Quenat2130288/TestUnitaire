using RetourPoo;
namespace RetourPooTest
{
    [TestClass]
    public class RoueTest
    {
        int largeur;
        int pourcentageHauteur;
        int diametreJante;
        int indiceCharge;
        char indiceVitesse;
        int pression;
        string type;
        Roue r;

        [TestInitialize]
        public void Init()
        {
            largeur = 0;
            pourcentageHauteur = 1;
            diametreJante = 2;
            indiceCharge = 3;
            indiceVitesse = 'A';
            pression = 4;
            type = "B";
            r = new Roue(largeur, pourcentageHauteur, diametreJante, indiceCharge, indiceVitesse, pression, type);
        }
        [TestCleanup]
        public void CleanUp()
        {
            largeur = 0;
            pourcentageHauteur = 0;
            diametreJante = 0;
            indiceCharge = 0;
            indiceVitesse = ' ';
            pression = 0;
            type = " ";
        }
        [TestMethod]
        public void Roue_valeurCorrecte_RoueAvecMemeValeur()
        {
            Assert.AreEqual<int>(largeur, r.largeur);
            Assert.AreEqual<int>(pourcentageHauteur, r.pourcentageHauteur);
            Assert.AreEqual<int>(diametreJante, r.diametreJante);
            Assert.AreEqual<int>(indiceCharge, r.indiceCharge);
            Assert.AreEqual<char>(indiceVitesse, r.indiceVitesse);
            Assert.AreEqual<int>(pression, r.pression);
            Assert.AreEqual<string>(type, r.type);
        }
        [TestMethod]
        public void SecondeRoue_valeurCorrecte_SecondeRoueAvecMemeValeur()
        {
            Roue secondeR = new Roue(r);
            Assert.AreEqual<int>(secondeR.largeur, r.largeur);
            Assert.AreEqual<int>(secondeR.pourcentageHauteur, r.pourcentageHauteur);
            Assert.AreEqual<int>(secondeR.diametreJante, r.diametreJante);
            Assert.AreEqual<int>(secondeR.indiceCharge, r.indiceCharge);
            Assert.AreEqual<int>(secondeR.indiceVitesse, r.indiceVitesse);
            Assert.AreEqual<int>(secondeR.pression, r.pression);
            Assert.AreEqual<string>(secondeR.type, r.type);
        }
        [TestMethod]
        public void Gonfler_pressionAugmenter_valeurPlusPression()
        {
            int pressionAjouter = 0;
            r.GonflerPneu(pressionAjouter);
            Assert.AreEqual<int>(pression + pressionAjouter, r.pression);
        }
    }
}