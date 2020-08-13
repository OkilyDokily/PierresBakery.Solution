using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;


namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
           
        }

        [TestMethod]
        public void AddToOrder_TestThatAmountsAreAddedProperly_True(){
            //arrange
            
            //act
            Order.AddToOrder("Brioche",5);
            Order.AddToOrder("Croissant",10);
        }

    }
}