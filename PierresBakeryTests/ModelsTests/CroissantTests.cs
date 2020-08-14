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
            Croissant c = new Croissant();
            int er = 12;
            //act
            int ar = c.Deal(9);
            Assert.AreEqual(er,ar);
        }
    }
}