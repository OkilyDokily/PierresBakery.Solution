namespace PierresBakery.Models
{
    public class Pastry : BakeryItem
    { 
        private static int _amount = 0;
        public new static int Amount {
        get{return _amount;}    
        set{
            BakeryItem.Amount = value;
            _amount = value;
        }}
        public Pastry()
        {
            DealPrice = 5;
            Multiplier = 3;
            SinglePrice = 2; 
        }
    }
}