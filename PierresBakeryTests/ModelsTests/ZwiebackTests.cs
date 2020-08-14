using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class ZwiebackTests : IDisposable
    {
        public void Dispose(){
            Cronut.Amount = 0; 
        }

        [TestMethod] 
        public void ImplementAmountSetter_EnsureAmountsWork_True()
        {
            //arrange
            int bakeryAmount = 20;
            int breadAmount = 20;
            //act
            Zwieback.Amount = 20;
            
            Assert.AreEqual(bakeryAmount, BakeryItem.Amount);
            Assert.AreEqual(breadAmount, Bread.Amount);
        }
    }
}