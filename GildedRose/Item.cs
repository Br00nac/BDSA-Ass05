namespace GildedRose
{

public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
        
        public void UpdateQuality(){

            if(SellIn < 0) Quality--;
            Quality--;
        }

    }
}