using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class ZwiebackTests{
       [TestMethod] 
        public void Deal_EnsureDefaultDealWorks_True()
        {
            //arrange
            int er = 20;
            //act
            int ar = (new Zwieback()).Deal(7);

            Assert.AreEqual(er,ar);
        }
    }
}