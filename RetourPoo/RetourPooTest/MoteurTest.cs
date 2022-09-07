using RetourPoo;
using System.IO;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace RetourPooTest
{
    [TestClass]
    public class MoteurTest
    {
        int taille;
        int nbCylindres;
        int puissanceChevaux;
        double consommationParKm;
        Moteur m;
        private const string Expected = "Vrooooom";

        [TestInitialize]
        public void Init()
        {
            taille = 0;
            nbCylindres = 1;
            puissanceChevaux = 2;
            consommationParKm = 3;
            m = new Moteur(taille, nbCylindres, puissanceChevaux, consommationParKm);
        }
        [TestCleanup]
        public void CleanUp()
        {
            taille = 0;
            nbCylindres = 0;
            puissanceChevaux = 0;
            consommationParKm = 0;
        }
        [TestMethod]
        public void Moteur_valeurCorrecte_MoteurAvecMemeValeur()
        {
            Assert.AreEqual<int>(taille, m.taille);
            Assert.AreEqual<int>(nbCylindres, m.nbCylindres);
            Assert.AreEqual<int>(puissanceChevaux, m.puissanceChevaux);
            Assert.AreEqual<double>(consommationParKm, m.consommationParKm);
        }
        [TestMethod]
        public void Moteur_stringCorrecte_AffichageCorrect()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                m.DemarrerMoteur();
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

    }
}