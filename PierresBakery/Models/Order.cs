using System.Collections.Generic;
using System.Linq;
using System;

namespace PierresBakery.Models
{
    public static class Order
    {
        public static Dictionary<string, BakeryItem> objectDictionary = new Dictionary<string,BakeryItem>(){{"Brioche", new Brioche()},{"Zwieback",new Zwieback()},{"Cronut",new Cronut()},{"Croissant",new Croissant()}}; 
      
        public static Dictionary<string,int> ordersAmount = new Dictionary<string,int>();
      
        public static void AddToOrder(string str, int num)
        {
            if (objectDictionary.ContainsKey(str))
            {
                if(ordersAmount.ContainsKey(str))
                {
                    ordersAmount[str] += num; 
                }
                else{
                    ordersAmount.Add(str, num);
                }
            }
        }
        

        public static Dictionary<string, Dictionary<string,int[]>> GetTotalsForAllOrder(){
            Dictionary<string,Dictionary<string,int[]>> totals = new Dictionary<string,Dictionary<string,int[]>>();  
            
            foreach(KeyValuePair<string,BakeryItem> entry in objectDictionary.ToList()){
                string key = entry.Key;
                int amount = 0;
                int total = 0;
                int[] arr = new int[2];
                BakeryItem bakery = objectDictionary[key];
                if(ordersAmount.ContainsKey(key))
                {
                    amount = ordersAmount[key];
                    total = bakery.Deal(amount);
                    arr[0] = amount;
                    arr[1] = total;
                    
                    string category = objectDictionary[key].Category;
                    if(!totals.ContainsKey(category))
                    {
                        int[] catArr = new int[]{0,0};
                        Dictionary<string,int[]> ofCategory = new Dictionary<string, int[]>(){{category, catArr}};
                        
                        totals.Add(category,ofCategory);   
                    }
                    totals[category][category][0] += amount;
                    totals[category][category][1] += total; 
                    totals[category].Add(key, arr);    
                }
            }
            return totals;
        }

    }
}