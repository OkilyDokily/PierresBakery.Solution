using System.Collections.Generic;
using System.Linq;
using System;

namespace PierresBakery.Models
{
    public static class Order
    {
        public static Dictionary<string, BakeryItem> objectDictionary = new Dictionary<string,BakeryItem>(){{"Brioche", new Brioche()},{"Zwieback",new Zwieback()},{"Cronut",new Cronut()},{"Croissant",new Croissant()}}; 
        public static List<string> names = new List<string>{"Brioche","Zwieback","Cronut","Croissant"};
        public static Dictionary<string,int> ordersAmount = new Dictionary<string,int>(){{"Brioche",0},{"Zwieback",0},{"Cronut", 0},{"Croissant",0}};
        public static Dictionary<string,int> categoryAmount = new Dictionary<string, int>(){{"Bread",0},{"Pastry",0}};
        
        
        public static void AddToOrder(string str, int num)
        {
            ordersAmount[str] += num;
            string category = objectDictionary[str].Category;
            categoryAmount[category] += num;    
        }

        public static Dictionary<string,int>[] GetTotalsForAllOrder(){
            Dictionary<string,int> totals = new Dictionary<string,int>();  
            Dictionary<string,int> categoryTotal = new Dictionary<string, int>();
            
            foreach(KeyValuePair<string,BakeryItem> entry in objectDictionary.ToList()){
                string key = entry.Key;
                int result = 0;
                BakeryItem bakery = objectDictionary[key];
                if(ordersAmount[key] > 0)
                {
                    result = bakery.Deal(ordersAmount[key]);
                    totals.Add(key,result);
                    string category = objectDictionary[key].Category;
                    if(categoryTotal.ContainsKey(category))
                    {
                        categoryTotal[category] += result;
                    }
                    else
                    {
                        categoryTotal.Add(category,result);
                    }
                }
            }
            return new Dictionary<string, int>[]{categoryTotal,totals};
        }
    }
}