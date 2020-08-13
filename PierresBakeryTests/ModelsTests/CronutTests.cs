using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class CronutTests
    {
        [TestMethod]
        public void ImplementNew_EnsureObjectCreatedCorrectlyTrue()
        {
            //arrange
            int er = 6;
            //act
            Cronut c = new Cronut();
            Assert.AreEqual(er,);
        }
    }
}