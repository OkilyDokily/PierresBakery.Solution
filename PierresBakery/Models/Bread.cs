namespace PierresBakery.Models
{
    public abstract class Bread : BakeryItem
    {
        public Bread() 
        {
            Multiplier = 2;
            DealPrice = 5;
            SinglePrice = 5;
        }
    }
}