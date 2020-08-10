using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod] 
        public void AddToOrder_TestIfListHoldsOrder_True(){
            //Arrange
            List<BakeryItem> er = new List<BakeryItem>(){new Pastry(5), new Bread(6), new Pastry(7)};
            //Act
            Order.AddToOrder(new Pastry(5));
            Order.AddToOrder(new Bread(6));
            Order.AddToOrder(new Pastry(7));
            //
            CollectionAssert.AreEqual(er, Order.Orders);
        }
    }
}