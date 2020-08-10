namespace PierresBakery.Models
{
    public class Bread
    {
        public int Amount{get;}
        public int SinglePrice{get;}
        public Bread(int amount)
        {
            SinglePrice = 5;
            Amount = amount;
        }

        public int TwoFor5Deal()
        {
            int doubleDeals = Amount / 2;
            return (doubleDeals * SinglePrice) + ((Amount % 2) * SinglePrice); 
        }

    }
}