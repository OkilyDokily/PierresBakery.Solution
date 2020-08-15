namespace PierresBakery.Models
{
    public class Pastry : BakeryItem
    { 
        public Pastry()
        {
            Category = "Pastry";
            DealPrice = 5;
            Multiplier = 3;
            SinglePrice = 2; 
        }
    }
}