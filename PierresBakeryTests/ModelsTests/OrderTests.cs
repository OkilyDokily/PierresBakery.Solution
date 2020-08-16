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
            List<string> keys2 = new List<string>(Order.categoryAmount.Keys);
            foreach(String str in keys2)
            {
                Order.categoryAmount[str] = 0;
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
        public void  GetTotalsForAllOrder_TestThatDealsReturnCorrectly_True(){
            //arrange
            Dictionary<string,int> er = new Dictionary<string,int>{{"Brioche",15},{"Croissant",7}};
            //act
            Order.AddToOrder("Brioche",5);
            Order.AddToOrder("Croissant",5);
            Dictionary<string, int> ar = Order.GetTotalsForAllOrder()[1];
            
            CollectionAssert.AreEqual(er,ar);
        }

          [TestMethod]
        public void  GetTotalsForAllOrder_TestThatCategoryTotalsAreAddedCorrectly_True(){
            //arrange
            Dictionary<string,int> er = new Dictionary<string,int>{{"Bread",30},{"Pastry",16}};
            //act
            Order.AddToOrder("Brioche",5); //15
            Order.AddToOrder("Zwieback",5);//15
            Order.AddToOrder("Croissant",5);//7
            Order.AddToOrder("Cronut",5);//9
            Dictionary<string,int> ar = Order.GetTotalsForAllOrder()[0];
          
            CollectionAssert.AreEqual(er,ar);
        }


         [TestMethod]
        public void  AddToOrder_GetTotalsOfItemsForEachCategory_True(){
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