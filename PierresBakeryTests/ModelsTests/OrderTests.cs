using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;


namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class OrderTests{

        [TestMethod]
        public void AddToOrder_TestThatAmountsAreAddedProperly_True(){
            //arrange
            Dictionary<string,int> er = new Dictionary<string,int>(){{"Brioche",5},{"Zwieback",0},{"Cronut", 0},{"Croissant",5}}; 
            //act
            Order.AddToOrder("Brioche",5);
            Order.AddToOrder("Croissant",5);

            CollectionAssert.AreEqual(er,Order.ordersAmount);
        }

    }
}