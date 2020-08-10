namespace PierresBakery.Models
{
    public class Pastry
    {
        public int Amount{get;}
        public int SinglePrice{get;}

        public Pastry(int amount)
        {
            SinglePrice = 2;
            Amount = amount;
        }

        public int ThreeFor5Deal(){
           int deal = Amount / 3;
           return (deal * 5) + ((Amount % 3) * SinglePrice); 
        }
    }
}