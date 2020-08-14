using System.Collections.Generic;
using System.Linq;
using System;

namespace PierresBakery.Models
{
    public static class Order
    {
        public static Dictionary<string,Type> typeDictionary = new Dictionary<string,Type>(){{"Brioche", typeof(Brioche)},{"Zwieback",typeof(Zwieback)},{"Cronunt",typeof(Cronut)},{"Croissant",typeof(Croissant)}}; 

        public static Dictionary<Type,string> typeStrDictionary = new Dictionary<Type,string>(){{typeof(Brioche),"Brioche"},{typeof(Zwieback),"Zwieback"},{typeof(Cronut),"Cronunt"},{typeof(Croissant),"Croissant"}}; 
        public static List<string> names = new List<string>{"Brioche","Zwieback","Cronut","Croissant"};
        public static Dictionary<string,int> ordersAmount = new Dictionary<string,int>(){{"Brioche",0},{"Zwieback",0},{"Cronut", 0},{"Croissant",0}}; 
        public static void AddToOrder(string str, int num)
        {
            ordersAmount[str] += num;
        }

        public static int GenericTotalMethodForDeals<T>() where T: BakeryItem, new(){
           T t = new T();
           string s = typeStrDictionary[typeof(T)];
           int amount = ordersAmount[s];
           return t.Deal(amount);
        }
    }
}