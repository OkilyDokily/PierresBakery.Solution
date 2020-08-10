using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void Constructor_EnsureConstructorWorks_True()
        {
            //arange
            Bread b = new Bread(5);
            //act
            bool ar = b.SinglePrice == 5 && b.Amount == 5;
            Assert.AreEqual(true, ar);
        }
        [TestMethod]
        public void TwoForFiveDeal()
        {
            //arrange
            Bread b = new Bread(5);
            int er = 15;
            //act
            int ar = b.deal();
            Assert.AreEqual(er,ar);
        }

        [TestMethod]
        public void ThreeForFiveDeal()
        {
            //arrange
            Pastry p = new Pastry(5);
            int er = 9;
            //act
            int ar = p.deal();
            Assert.AreEqual(er,ar);
        }
    }
}