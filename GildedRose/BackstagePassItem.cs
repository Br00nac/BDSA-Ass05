using System;

namespace GildedRose{
public class BPItem : Program.Item

    {

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public override void UpdateQuality()
        {

        
            switch(SellIn)
            {

                default : Quality++;break;

                case 10 :  Quality += 2; break;

                case 5 : Quality += 3; break;

                case <0 : Quality = 0; break;


            }

            if (Quality < 0) Quality = 0;
            if (Quality > 50) Quality = 50;

            



        }
        
    }
}