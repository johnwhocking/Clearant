using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardInterestTests
{
    [TestClass]
    public class CreditCardInterestTests
    {
        [TestMethod]
        public void OneWalletThreeCards_VisaMCdDiscover_Returns16()
        {
            double Results = 0;
            //Wallet 1
            Results = Results + CreditCardInterest.CreditCardInterest.CalcInterest("Visa",100);
            Results = Results + CreditCardInterest.CreditCardInterest.CalcInterest("MC", 100);
            Results = Results + CreditCardInterest.CreditCardInterest.CalcInterest("Discover", 100);
            Assert.AreEqual(16,Results);
        }

        [TestMethod]
        public void TwoWalletsThreeCards_VisaMCDiscover_Returns10and6()
        {
            double Results = 0;
            //Wallet 1 
            Results = Results + CreditCardInterest.CreditCardInterest.CalcInterest("Visa", 100);
            Assert.AreEqual(10, Results);
            
            //Wallet 2
            Results = 0;
            Results = Results + CreditCardInterest.CreditCardInterest.CalcInterest("Discover", 100);
            Results = Results + CreditCardInterest.CreditCardInterest.CalcInterest("MC", 100);
            Assert.AreEqual(6, Results);
        }

        [TestMethod]
        public void TwoPeopleTwoWalletsTwoCardsEach_VisaMC_Returns15()
        {
            double Results = 0;
            //Wallet 1 
            Results = Results + CreditCardInterest.CreditCardInterest.CalcInterest("Visa", 100);
            Results = Results + CreditCardInterest.CreditCardInterest.CalcInterest("MC", 100);
            Assert.AreEqual(15, Results);

            //Wallet 2
            Results = 0;
            Results = Results + CreditCardInterest.CreditCardInterest.CalcInterest("Visa", 100);
            Results = Results + CreditCardInterest.CreditCardInterest.CalcInterest("MC", 100);
            Assert.AreEqual(15, Results);
        }
    }
}
