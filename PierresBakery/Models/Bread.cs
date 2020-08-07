namespace PierresBakery.Models
{
    public class Bread
    {
        public int Amount{get;}
        public int SinglePrice{get;}
        public Bread(int amount){
            SinglePrice = 5;
            Amount = amount;
        }

    }
}