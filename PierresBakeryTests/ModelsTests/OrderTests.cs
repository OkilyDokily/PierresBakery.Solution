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
        public void Dispose()
        {
            List<string> keys = new List<string>(Order.ordersAmount.Keys);
            foreach(String str in keys)
            {
                Order.ordersAmount[str] = 0;
            }
            List<string> keys2 = new List<string>(Order.categoryAmount.Keys);
            foreach(String str in keys2)
            {
                Order.categoryAmount[str] = 0;
            }
        } 

        [TestMethod]
        public void AddToOrder_TestThatAmountsAreAddedProperly_True()
        {
            //arrange
            Dictionary<string,int> er = new Dictionary<string,int>(){{"Brioche",5},{"Zwieback",0},{"Cronut", 0},{"Croissant",5}}; 
            //act
            Order.AddToOrder("Brioche",5);
            Order.AddToOrder("Croissant",5);

            CollectionAssert.AreEqual(er,Order.ordersAmount);
        }


        [TestMethod]
        public void GetTotalsForAllOrder_TestThatDealsReturnCorrectly_True()
        {
            //arrange
            int eBriocheTotal = 15;
            int eCroissantTotal = 7;
            
            //act
            Order.AddToOrder("Brioche",5);
            Order.AddToOrder("Croissant",5);
            int aBriocheTotal = Order.GetTotalsForAllOrder()["Bread"]["Brioche"][1];
            int aCroissantTotal = Order.GetTotalsForAllOrder()["Pastry"]["Croissant"][1];

            Assert.AreEqual(true, eBriocheTotal == aBriocheTotal && eCroissantTotal == aCroissantTotal);
        }

         [TestMethod]
        public void GetTotalsForAllOrder_TestThatLengthOfCategoryDictionaryIsCorrect_True()
        {
            //arrange
            int eBreadLength = 2;
            int ePastryLength = 2;
            
            //act
            Order.AddToOrder("Brioche",5);
            Order.AddToOrder("Croissant",5);

            int aBreadLength = Order.GetTotalsForAllOrder()["Bread"].Count;
            int aPastryLength = Order.GetTotalsForAllOrder()["Pastry"].Count;

            Assert.AreEqual(true, eBreadLength== aBreadLength && ePastryLength == aPastryLength);
        }

        [TestMethod]
        public void GetTotalsForAllOrder_TestThatLengthOfOverallDictionaryIsCorrect_True()
        {
            //arrange
            int eLength = 1;
            
            //act
            Order.AddToOrder("Brioche",5);
            int aLength = Order.GetTotalsForAllOrder().Count;
            
            Assert.AreEqual(eLength,aLength);
        }

          [TestMethod]
        public void GetTotalsForAllOrder_TestThatCategoryTotalsAreAddedCorrectly_True()
        {
            //arrange
            int eBreadTotal =  30;
            int ePastryTotal = 16;

            //act
            Order.AddToOrder("Brioche",5); //15
            Order.AddToOrder("Zwieback",5);//15
            Order.AddToOrder("Croissant",5);//7
            Order.AddToOrder("Cronut",5);//9
            
            int aBreadTotal = Order.GetTotalsForAllOrder()["Bread"]["Bread"][1];
            int aPastryTotal = Order.GetTotalsForAllOrder()["Pastry"]["Pastry"][1];
          
            Assert.AreEqual(true, eBreadTotal == aBreadTotal && ePastryTotal == aPastryTotal);
        }


         [TestMethod]
        public void AddToOrder_GetTotalsOfItemsForEachCategory_True()
        {
            //arrange
            Dictionary<string,int> er = new Dictionary<string,int>{{"Bread",10},{"Pastry",10}};
            //act
            Order.AddToOrder("Brioche",5);
            Order.AddToOrder("Zwieback",5);
            Order.AddToOrder("Croissant",5);
            Order.AddToOrder("Cronut",5);
           
            CollectionAssert.AreEqual(er,Order.categoryAmount);
        }
    }
}