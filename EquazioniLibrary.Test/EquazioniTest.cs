using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;
namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 10;
            bool valore_aspettato = true;
            bool risultato = Equazioni.isDetermined(a);
            Assert.AreEqual(valore_aspettato, risultato);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double a = 0;
            double b = 10;
            bool valore_aspettato = true;
            bool risultato = Equazioni.isInconsisted(a, b);
            Assert.AreEqual(valore_aspettato, risultato);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double g = 2;
            bool valore_aspettato = true;
            bool risultato = Equazioni.isDegree2(g);
            Assert.AreEqual(valore_aspettato, risultato);
        }

        [TestMethod]
        public void TestMethod4()
        {
            double a = 2;
            double b = 2;
            double c = 4;
            double valore_aspettato = -28;
            double prova = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valore_aspettato, prova);
        }

        [TestMethod]
        public void TestMethod5()
        {

        }




    }
}
