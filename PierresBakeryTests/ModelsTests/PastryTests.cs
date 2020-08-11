using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void Constructor_EnsureConstructorWorks_True()
        {
            //arange
            Pastry p = new Pastry(5);
            //act
            bool ar = p.SinglePrice == 2 && p.Amount == 5;
            Assert.AreEqual(true, ar);
        }

        [TestMethod]
        public void ThreeForFiveDeal_GetValueOfOrder_True()
        {
            //arrange
            Pastry p = new Pastry(5);
            int er = 9;
            //act
            int ar = p.Deal();
            Assert.AreEqual(er,ar);
        }
    }
}