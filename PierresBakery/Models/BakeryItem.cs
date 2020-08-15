namespace PierresBakery.Models
{
    public abstract class BakeryItem
    {
        public string Category{get; set;}
        public int SinglePrice{get; set;}
        public int Multiplier{get; set;}
        public int DealPrice{get; set;}

        public int Deal(int amount)
        {
            int deal = amount / Multiplier;
            return (deal * DealPrice) + ((amount % Multiplier) * SinglePrice); 
        }
    }
}