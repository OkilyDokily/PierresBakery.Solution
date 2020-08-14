using System.Collections.Generic;
using System.Linq;
using System;

namespace PierresBakery.Models
{
    public static class Order
    {
        public static List<Type> typeList = new List<Type>(){typeof(Brioche),typeof(Croissant),typeof(Cronut),typeof(Zwieback)}; 
        public static List<string> names = new List<string>{"Brioche","Zwieback","Cronut","Croissant"};
        public static Dictionary<string,int> ordersAmount = new Dictionary<string,int>(){{"Brioche",0},{"Zwieback",0},{"Cronut", 0},{"Croissant",0}}; 
        public static void AddToOrder(string str, int num)
        {
            ordersAmount[str] += num;
        }
    }
}