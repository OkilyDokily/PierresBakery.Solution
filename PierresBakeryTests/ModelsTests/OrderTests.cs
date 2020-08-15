using PierresBakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Linq;

namespace PierresBakeryTests.ModelsTests
{
    [TestClass]
    public class OrderTests 
    : IDisposable
    {
        public void Dispose(){
            List<string> keys = new List<string>(Order.ordersAmount.Keys);
            foreach(String str in keys)
            {
                Order.ordersAmount[str] = 0;
            }
        } 

        [TestMethod]
        public void AddToOrder_TestThatAmountsAreAddedProperly_True(){
            //arrange
            Dictionary<string,int> er = new Dictionary<string,int>(){{"Brioche",5},{"Zwieback",0},{"Cronut", 0},{"Croissant",5}}; 
            //act
            Order.AddToOrder("Brioche",5);
            Order.AddToOrder("Croissant",5);

            CollectionAssert.AreEqual(er,Order.ordersAmount);
        }


        [TestMethod]
        public void  GenericTotalMethodForDeals_TestThatDealReturnsCorrectly_True(){
            //arrange
            int er = 7;
            Order.AddToOrder("Croissant",5);
            int ar = Order.GenericTotalMethodForDeals<Croissant>();
            Assert.AreEqual(er,ar);
        }

        

    }
}