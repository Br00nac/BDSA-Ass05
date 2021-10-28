using System;

namespace GildedRose{
public class AgedItem : Item

    {


        new public void UpdateQuality(){
            
            if(Quality < 50) Quality++;
            
            
            }
        
    }
}

