using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class CroissantTests {
        [TestMethod]
        public void Deal_FourForFive_True()
        {
            //arrange
            Brioche b = new Brioche();
            int er = 12;
            //act
            int ar = b.Deal(9);
            Assert.AreEqual(er,ar);
        }
    }
}