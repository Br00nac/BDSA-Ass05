using System;

namespace GildedRose{
public class BPItem : Item

    {

        new public void UpdateQuality()
        {

        
            switch(SellIn)
            {

                default : Quality++;break;

                case 10 :  Quality += 2; break;

                case 5 : Quality += 3; break;

                case <0 : Quality = 0; break;


            }


            



        }
        
    }
}