using System;

namespace GildedRose{
public class NormalItem : Program.Item

    {

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public override void UpdateQuality()
        {
            if(SellIn < 0) Quality--;
            Quality--;
            if (Quality < 0) Quality = 0;
            if (Quality > 50) Quality = 50;
        
        
        }
        
    }
}