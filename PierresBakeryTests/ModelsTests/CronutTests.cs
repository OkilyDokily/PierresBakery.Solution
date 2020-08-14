using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class CronutTests{
        [TestMethod] 
        public void Deal_EnsureDefaultDealWorks_True()
        {
            //arrange
            int er = 17;
            //act
            int ar = (new Cronut()).Deal(10);

            Assert.AreEqual(er,ar);
        }
    }
}