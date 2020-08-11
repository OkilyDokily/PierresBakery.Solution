using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class ZwiebackTests
    {
        [TestMethod]
        public void ImplementNew_EnsureObjectCreatedCorrectlyTrue()
        {
            //arrange
            int er = 6;
            //act
            Zwieback z = new Zwieback(6);
            Assert.AreEqual(er,z.Amount);
        }
    }
}