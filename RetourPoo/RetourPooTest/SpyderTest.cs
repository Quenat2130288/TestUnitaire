using RetourPoo;
namespace RetourPooTest
{
    [TestClass]
    public class SpyderTest
    {
        string style;
        Moteur m;
        Roue r;
        Spyder s;
        private const string Expected = "Pour faire le tournant serre, vous avez simplement tourner la direction de la Spyder";

        [TestInitialize]
        public void Init()
        {
            style = "Spyder";
            m = new Moteur(1, 2, 3, 4);
            r = new Roue(1, 2, 3, 4, 'a', 5, "b");
            s = new Spyder(1, 2, m, r, "a", "b", "c");
        }
        [TestMethod]
        public void Spyder_StyleCorrect_StyleDeMotoCorrect()
        {
            Assert.AreEqual<string>(style, s.style);
        }
        [TestMethod]
        public void Spyder_stringCorrecte_AffichageCorrect()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                s.TournerSerrer();
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}