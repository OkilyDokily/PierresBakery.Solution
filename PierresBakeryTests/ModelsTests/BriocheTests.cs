using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class BriocheTests
    {
        [TestMethod] 
        public void ImplementNew_EnsureObjectCreatedCorrectlyTrue()
        {
            //arrange
            int er = 6;
            //act
            Brioche b = new Brioche(6);
            Assert.AreEqual(er,b.Amount);
        }
    }
}