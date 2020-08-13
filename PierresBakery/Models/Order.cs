using System.Collections.Generic;
using System.Linq;
using System;

namespace PierresBakery.Models
{
    public class Order
    {
        public static Dictionary<Type,string> typeList = new Dictionary<Type,string>(){{typeof(Brioche),"Brioche"},{typeof(Croissant),"Croissant"},{typeof(Cronut), "Cronut"},{typeof(Zwieback),"Zwieback"}}; 
        public static List<BakeryItem> Orders = new List<BakeryItem>();
        public static void AddToOrder(BakeryItem item)
        {
            Orders.Add(item);
        }

        public static int GetTotalNumberOfAType(List<BakeryItem> list)
        {
            return list.Sum(item => item.Amount);   
        }

        public static int GetTotalValueOfOrdersForAType<T>(int total) where T : BakeryItem{
            //https://stackoverflow.com/questions/731452/create-instance-of-generic-type-whose-constructor-requires-a-parameter
            T item = (T)Activator.CreateInstance(typeof(T), new object[] { total });
            return item.Deal();
        }
    }
}