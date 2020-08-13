using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class CroissantTests
    {
        [TestMethod]
        public void ImplementNew_EnsureObjectCreatedCorrectlyTrue()
        {
              //arrange
            int er = 6;
            //act
            Croissant c = new Croissant();
            Assert.AreEqual(er,);
        }

        public void Deal_FourForFive_True()
        {
            //arrange
            Brioche b = new Brioche();
            int er = 7;
            //act
            int ar = b.Deal();
            Assert.AreEqual(er,ar);
        }
    }
}