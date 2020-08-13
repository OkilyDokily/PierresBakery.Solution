namespace PierresBakery.Models
{
    public class Pastry : BakeryItem
    { 
        public Pastry(int amount) : base() 
        {
            Amount = amount;
            DealPrice = 5;
            Multiplier = 3;
            SinglePrice = 2; 
        }
    }
}