namespace PierresBakery.Models
{
    public abstract class BakeryItem
    {
        public int Amount{get; set;}
        public int SinglePrice{get; set;}

        public abstract int deal();
    }
}