namespace PierresBakery.Models
{
    public class Pastry : BakeryItem
    {
      
        public Pastry(int amount) 
        {
            SinglePrice = 2;
            Amount = amount;
        }

        public override int deal(){
           int deal = Amount / 3;
           return (deal * 5) + ((Amount % 3) * SinglePrice); 
        }
    }
}