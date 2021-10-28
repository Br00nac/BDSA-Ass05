using System;

namespace GildedRose{
public class LegendaryItem : Program.Item

    {

        public string Name { get; set; }

        public int SellIn { get; set; }

        public  int Quality {get; set;}

        public override void UpdateQuality(){ Quality = 80;}
        
    }
}