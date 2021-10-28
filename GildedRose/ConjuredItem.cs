using System;

namespace GildedRose{
public class ConjuredItem : Item

    {


        new public void UpdateQuality()
        {
            
            if(SellIn < 0) Quality -= 2;
            Quality -= 2;
            
        
        }
        
    }
}