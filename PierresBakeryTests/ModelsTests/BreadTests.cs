using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void Constructor_EnsureConstructorWorks_True(){
            //arange
            Bread b = new Bread(5);
            //act
            bool ar = b.SinglePrice == 5 && b.Amount == 5;
            Assert.AreEqual(true, ar);
        }
        [TestMethod]
        public void Two
    }
}