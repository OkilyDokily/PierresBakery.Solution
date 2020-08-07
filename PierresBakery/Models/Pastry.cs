namespace PierresBakery.Models
{
    public class Pastry
    {
        public int Amount{get;}
        public int SinglePrice{get;}

        public Pastry(int amount){
            SinglePrice = 2;
            Amount = amount;
        }
    }
}