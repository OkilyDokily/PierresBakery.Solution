using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class CroissantTests : IDisposable
    {
        public void Dispose(){
            Cronut.Amount = 0; 
        }
          [TestMethod] 
        public void ImplementAmountSetter_EnsureAmountsWorkTrue()
        {
            //arrange
            int bakeryAmount = 20;
            int breadAmount = 20;
            //act
            Croissant.Amount = 20;
            
            Assert.AreEqual(bakeryAmount, BakeryItem.Amount);
            Assert.AreEqual(breadAmount, Bread.Amount);
           
        }

        // public void Deal_FourForFive_True()
        // {
        //     //arrange
        //     Brioche b = new Brioche();
        //     int er = 7;
        //     //act
        //     int ar = b.Deal();
        //     Assert.AreEqual(er,ar);
        // }
    }
}