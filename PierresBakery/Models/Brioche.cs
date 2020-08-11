namespace PierresBakery.Models
{
    public class Brioche : Bread
    {
        public Brioche(int num) : base(num)
        {
           Multiplier = 3;
           DealPrice = 7; 
           SinglePrice = 4;  
        }
    }
}