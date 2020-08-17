using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class BriocheTests 
    {
        [TestMethod]
        public void Deal_ThreeForSeven_True()
        {
            //arrange
            Brioche b = new Brioche();
            int er = 11;
            //act
            int ar = b.Deal(4);
            
            Assert.AreEqual(er,ar);
        }
    }
}