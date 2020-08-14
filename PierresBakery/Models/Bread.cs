namespace PierresBakery.Models
{
    public abstract class Bread : BakeryItem
    {
        private static int _amount = 0;
        public new static int Amount {
        get{return _amount;}    
        set{
            BakeryItem.Amount = value;
            _amount = value;
        }}
        public Bread() 
        {
            Multiplier = 2;
            DealPrice = 5;
            SinglePrice = 5;
        }
    }
}