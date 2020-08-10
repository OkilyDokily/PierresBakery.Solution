namespace PierresBakery.Models
{
    public class Pastry : BakeryItem
    {
      
        public Pastry(int amount) 
        {
            DealPrice = 5;
            Multiplier = 3;
            SinglePrice = 2;
            Amount = amount;
        }
    }
}