using System.Collections.Generic;
using System.Linq;
using System;

namespace PierresBakery.Models
{
    public static class Order
    {
        public static Dictionary<string, BakeryItem> objectDictionary = new Dictionary<string,BakeryItem>(){{"Brioche", new Brioche()},{"Zwieback",new Zwieback()},{"Cronunt",new Cronut()},{"Croissant",new Croissant()}}; 

        public static Dictionary<Type,string> typeStrDictionary = new Dictionary<Type,string>(){{typeof(Brioche),"Brioche"},{typeof(Zwieback),"Zwieback"},{typeof(Cronut),"Cronunt"},{typeof(Croissant),"Croissant"}}; 
        public static List<string> names = new List<string>{"Brioche","Zwieback","Cronut","Croissant"};
        public static Dictionary<string,int> ordersAmount = new Dictionary<string,int>(){{"Brioche",0},{"Zwieback",0},{"Cronut", 0},{"Croissant",0}};

        public static Dictionary<string,int> totals = new Dictionary<string,int>();  
        public static void AddToOrder(string str, int num)
        {
            ordersAmount[str] += num;
        }

        public static int CallDealMethodWithString(string str)
        {
          return objectDictionary[str].Deal(ordersAmount[str]);
        }

        // public static void GenericTotalMethodForDeals(){
        //    foreach(KeyValuePair<string,Type> entry in typeDictionary.ToList()){
        //        string key = entry.Key;
        //        Type type = typeDictionary[key];
        //        GenericTotalMethodForDeals<typeof(type)>();
        //    }
        // }
    }
}