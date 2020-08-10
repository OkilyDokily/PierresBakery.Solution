using System.Collections.Generic;
namespace PierresBakery.Models
{
    public class Order
    {
        public static List<BakeryItem> Orders = new List<BakeryItem>();
        public static void AddToOrder(BakeryItem item){
            Orders.Add(item);
        }

        
    }
}