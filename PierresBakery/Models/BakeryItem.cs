namespace PierresBakery.Models
{
    public abstract class BakeryItem
    {
        private static int _amount = 0;
        public static int Amount {
        get{return _amount;}    
        set{
            _amount = value;
        }}
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