using System.Collections.Generic;
using System.Linq;

namespace PierresBakery.Models
{
    public class Order
    {
        public static List<BakeryItem> Orders = new List<BakeryItem>();
        public static void AddToOrder(BakeryItem item)
        {
            Orders.Add(item);
        }

        public static int GetTotal()
        {
            return Orders.Sum(item => item.Deal());   
        }
    }
}