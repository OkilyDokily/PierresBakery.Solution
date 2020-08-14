namespace PierresBakery.Models
{
    public class Brioche : Bread 
    {
        private static int _amount = 0;
        public new static int Amount {
        get{return _amount;}    
        set{
            Bread.Amount = value;
            _amount = value;
        }}
        public Brioche() 
        {
           Multiplier = 3;
           DealPrice = 7; 
           SinglePrice = 4;  
        }
    }
}