namespace PierresBakery.Models
{
    public class Zwieback : Bread
    {
        private static int _amount = 0;
        public new static int Amount {
        get{return _amount;}    
        set{
            Bread.Amount = value;
            _amount = value;
        }}
        public Zwieback() : base()
        {
            
        }
    }
}