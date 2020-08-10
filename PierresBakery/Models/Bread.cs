namespace PierresBakery.Models
{
    public class Bread : BakeryItem
    {
        public Bread(int amount)
        {
            Multiplier = 2;
            DealPrice = 5;
            SinglePrice = 5;
            Amount = amount;
        }

        

    }
}