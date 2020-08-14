namespace PierresBakery.Models
{
    public class Cronut : Pastry
    {
        private static int _amount = 0;
        public new static int Amount {
        get{return _amount;}    
        set{
            Pastry.Amount = value;
            _amount = value;
        }}
        public Cronut() : base()
        {
           
        }
    }
}