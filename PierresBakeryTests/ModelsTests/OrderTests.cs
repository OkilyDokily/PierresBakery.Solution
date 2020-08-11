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
            Order.Orders.Clear();
        }

        [TestMethod] 
        public void AddToOrder_TestIfListHoldsOrder_True()
        {
            //Arrange
            List<BakeryItem> er = new List<BakeryItem>(){new Pastry(5), new Bread(6), new Pastry(7)};
            //Act
            Order.AddToOrder(new Pastry(5));
            Order.AddToOrder(new Bread(6));
            Order.AddToOrder(new Pastry(7));
            //
            CollectionAssert.AreEqual(er, Order.Orders);
        }
        [TestMethod]
        public void AddToOrder_TestIfListHoldsOrder_False()
        {
            //Arrange
            List<BakeryItem> er = new List<BakeryItem>(){new Bread(5), new Bread(6), new Pastry(7)};
            //Act
            Order.AddToOrder(new Pastry(5));
            Order.AddToOrder(new Bread(6));
            Order.AddToOrder(new Pastry(7));
            //
            CollectionAssert.AreNotEqual(er, Order.Orders);
        }

        [TestMethod]
        public void GetTotal_GetTotalOfOrders_True()
        {
            //Arrange
            int er = 36;
            //Act
            Order.AddToOrder(new Pastry(5)); //9
            Order.AddToOrder(new Bread(6));  //15
            Order.AddToOrder(new Pastry(7)); //12
            //
            Assert.AreEqual(er, Order.GetTotal());
        }
    }
}