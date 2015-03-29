using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Yatzy.Tests
{
    [TestClass]
    public class YatzyTests
    {
        [TestMethod]
        public void RetourneCINQSiLeTotalDesDèsVautCINQ()
        {
            BS.Yatzy yatzy = new BS.Yatzy(1, 1, 1, 1, 1);
            Assert.AreEqual(5, yatzy.Chance());
        }

        [TestMethod]
        public void RetourneDOUZESiLeTotalDesDèsVautDOUZE()
        {
            BS.Yatzy yatzy = new BS.Yatzy(6, 2, 2, 1, 1);
            Assert.AreEqual(12, yatzy.Chance());
        }


        [TestMethod]
        public void RetourneCINQUANTESiCINQDèsIdentique()
        {
            BS.Yatzy yatzy = new BS.Yatzy(1, 1, 1, 1, 1);
            Assert.AreEqual(50, yatzy.yatzy());
        }

        [TestMethod]
        public void RetourneZEROSiAuMoinsUnDèsEstDifferent()
        {
            BS.Yatzy yatzy = new BS.Yatzy(1, 2, 1, 1, 1);
            Assert.AreEqual(0, yatzy.yatzy());
        }


        [TestMethod]
        public void RetourneZEROSiAucunDesAPourValeurUN()
        {
            BS.Yatzy yatzy = new BS.Yatzy(2, 2, 2, 2, 4);
            Assert.AreEqual(0, yatzy.GetTotalOfDicesWithSameValue(1));
        }

        [TestMethod]
        public void RetourneQUATRESiQUATREDesAPourValeurUN()
        {
            BS.Yatzy yatzy = new BS.Yatzy(1, 1, 1, 1, 4);
            Assert.AreEqual(4, yatzy.GetTotalOfDicesWithSameValue(1));
        }

        [TestMethod]
        public void RetourneZEROSiAucunDesAPourValeurDEUX()
        {
            BS.Yatzy yatzy = new BS.Yatzy(1, 4, 3, 5, 6);
            Assert.AreEqual(0, yatzy.GetTotalOfDicesWithSameValue(2));
        }

        [TestMethod]
        public void RetourneDEUXSiDEUXDesAPourValeurDEUX()
        {
            BS.Yatzy yatzy = new BS.Yatzy(2, 2, 3, 5, 6);
            Assert.AreEqual(2, yatzy.GetTotalOfDicesWithSameValue(2));
        }

        [TestMethod]
        public void RetourneZEROSiAucunDesAPourValeurTROIS()
        {
            BS.Yatzy yatzy = new BS.Yatzy(1, 2, 4, 5, 6);
            Assert.AreEqual(0, yatzy.GetTotalOfDicesWithSameValue(3));
        }

        [TestMethod]
        public void RetourneDEUXSiDEUXDesAPourValeurTROIS()
        {
            BS.Yatzy yatzy = new BS.Yatzy(3, 2, 3, 5, 6);
            Assert.AreEqual(2, yatzy.GetTotalOfDicesWithSameValue(3));
        }

        [TestMethod]
        public void RetourneZEROSiAucunDesAPourValeurQUATRE()
        {
            BS.Yatzy yatzy = new BS.Yatzy(1, 2, 3, 5, 6);
            Assert.AreEqual(0, yatzy.GetTotalOfDicesWithSameValue(4));
        }

        [TestMethod]
        public void RetourneCINQSiCINQDesAPourValeurQUATRE()
        {
            BS.Yatzy yatzy = new BS.Yatzy(4, 4, 4, 4, 4);
            Assert.AreEqual(5, yatzy.GetTotalOfDicesWithSameValue(4));
        }

        [TestMethod]
        public void RetourneZEROSiAucunDesAPourValeurCINQ()
        {
            BS.Yatzy yatzy = new BS.Yatzy(1, 2, 3, 4, 6);
            Assert.AreEqual(0, yatzy.GetTotalOfDicesWithSameValue(5));
        }

        [TestMethod]
        public void RetourneUNSiUNDesAPourValeurCINQ()
        {
            BS.Yatzy yatzy = new BS.Yatzy(4, 4, 4, 5, 4);
            Assert.AreEqual(1, yatzy.GetTotalOfDicesWithSameValue(5));
        }

        [TestMethod]
        public void RetourneZEROSiAucunDesAPourValeurSIX()
        {
            BS.Yatzy yatzy = new BS.Yatzy(1, 2, 3, 5, 4);
            Assert.AreEqual(0, yatzy.GetTotalOfDicesWithSameValue(6));
        }

        [TestMethod]
        public void RetourneUNSiUNDesAPourValeurSIX()
        {
            BS.Yatzy yatzy = new BS.Yatzy(4, 4, 4, 4, 6);
            Assert.AreEqual(1, yatzy.GetTotalOfDicesWithSameValue(6));
        }

        [TestMethod]
        public void RetourneDEUXauScorePair()
        {
            Assert.AreEqual(2, BS.Yatzy.ScorePair(1, 1, 2, 3, 4));
        }

        [TestMethod]
        public void RetourneQUATREauScorePair()
        {
            Assert.AreEqual(4, BS.Yatzy.ScorePair(2, 2, 1, 3, 4));
        }

        [TestMethod]
        public void RetourneZEROauScorePair()
        {
            Assert.AreEqual(0, BS.Yatzy.ScorePair(2, 5, 1, 6, 4));
        }

        [TestMethod]
        public void RetourneDOUZEauScorePair()
        {
            Assert.AreEqual(12, BS.Yatzy.ScorePair(2, 6, 6, 6, 4));
        }

    }
}
