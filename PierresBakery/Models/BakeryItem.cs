namespace PierresBakery.Models
{
    public class BakeryItem
    {
        public int Amount{get; set;}
        public int SinglePrice{get; set;}
        public int Multiplier{get; set;}
        public int DealPrice{get; set;}

        public int deal(){
            int deal = Amount / Multiplier;
            return (deal * DealPrice) + ((Amount % Multiplier) * SinglePrice); 
        }
        //for testing purposes
        public override bool Equals(object obj) {
            BakeryItem other = obj as BakeryItem;
            if(other == null) {
                return false;
            }
            return (this.Amount == other.Amount);
        }
    }
}