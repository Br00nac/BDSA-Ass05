using System;

namespace GildedRose{
public class AgedItem : Program.Item

    {

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public override void UpdateQuality(){
            
            if(Quality < 50) Quality++;
            if (Quality < 0) Quality = 0;
            if (Quality > 50) Quality = 50;
            
            
            }
        
    }
}

