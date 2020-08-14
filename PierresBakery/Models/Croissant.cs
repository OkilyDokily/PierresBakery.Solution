namespace PierresBakery.Models
{
    public class Croissant : Pastry
    {
        private static int _amount = 0;
        public new static int Amount {
        get{return _amount;}    
        set{
            Pastry.Amount = value;
            _amount = value;
        }}
        public Croissant() : base()
        {
            Multiplier = 4;
            DealPrice = 5;
        }
    }
}