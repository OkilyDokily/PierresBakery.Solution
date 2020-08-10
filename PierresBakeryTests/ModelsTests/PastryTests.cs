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
    }
}