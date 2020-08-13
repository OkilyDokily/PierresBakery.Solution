namespace PierresBakery.Models
{
    public abstract class Bread : BakeryItem
    {

        public Bread(int num) 
        {
            Amount = num;
            Multiplier = 2;
            DealPrice = 5;
            SinglePrice = 5;
        }
    }
}