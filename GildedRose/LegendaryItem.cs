using System;

namespace GildedRose{
public class LegendaryItem : Program.Item

    {

        public string Name { get; set; }

        public int SellIn { get; set; }

        public readonly int Quality = 80;

        public override void UpdateQuality(){}
        
    }
}