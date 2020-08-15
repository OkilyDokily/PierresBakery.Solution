namespace PierresBakery.Models
{
    public abstract class Bread : BakeryItem 
    {
        public Bread() 
        {
            Category = "Bread";
            Multiplier = 2;
            DealPrice = 5;
            SinglePrice = 5;
        }
    }
}