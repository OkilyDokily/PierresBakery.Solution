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
            Croissant c = new Croissant(6);
            Assert.AreEqual(er,c.Amount);
        }
    }
}