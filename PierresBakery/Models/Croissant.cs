namespace PierresBakery.Models
{
    public class Croissant : Pastry
    {
        public Croissant(int num) : base(num)
        {
            Multiplier = 4;
            DealPrice = 5;
        }
    }
}