namespace PierresBakery.Models
{
    public class Bread : BakeryItem
    {
       
        public Bread(int amount)
        {
            SinglePrice = 5;
            Amount = amount;
        }

        public override int deal()
        {
            int doubleDeals = Amount / 2;
            return (doubleDeals * SinglePrice) + ((Amount % 2) * SinglePrice); 
        }

    }
}