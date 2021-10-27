using System;

namespace GildedRose{
public class ConjuredItem : Program.Item

    {

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public override void UpdateQuality()
        {
            
            if(SellIn < 0) Quality -= 2;
            Quality -= 2;
            if (Quality < 0) Quality = 0;
            if (Quality > 50) Quality = 50;
        
        }
        
    }
}