using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Program
    {
        public static readonly int MONTH = 31;
        public static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");
            var l = defaultList();
            showAllItemValuesForAMonth(l);
        }
        public static IList<Item> defaultList()
        {
            var list = new List<Item>
            {
                new NormalItem { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new AgedItem { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new NormalItem { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new LegendaryItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0},
                new LegendaryItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1},

                new BPItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new BPItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new BPItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
                // this conjured item does not work properly yet
                new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
            };
            return list;
        }

        public static void showAllItemValuesForAMonth(IList<Item> Items)
        {
            for (var i = 0; i < Program.MONTH; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");

                for (var j = 0; j < Items.Count; j++)
                {
                    Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                    
                    Items[j].UpdateQuality();
                    UpdateSellIn(Items[j]);
                }
                
                Console.WriteLine("");
            }
        }

        public static void UpdateSellIn(Item i){
            i.SellIn--;
        }

    //     public static void UpdateQuality(Item i)
    //     {
    //         if(i.Name.StartsWith("Conjured")){ i.Quality = i.Quality -2; return; }

    //             switch (i.Name)
    //             {
    //                 case "Aged Brie":
    //                     i.Quality++;
    
    //                 break;

    //                 case "Backstage passes to a TAFKAL80ETC concert":
    //                     if(i.SellIn < 11) i.Quality++;
    //                     if(i.SellIn < 6) i.Quality++;
                        
    //                     i.Quality++;

    //                     if(i.SellIn < 0) i.Quality = 0;
    //                 break;

    //                 case "Sulfuras, Hand of Ragnaros":
        
    //                 break;

    //                 default:
    //                     if (i.SellIn < 0) i.Quality--;
    //                     i.Quality--;
    //                 break;
    //             }
    //         if (i.Quality < 0) i.Quality = 0;
    //         if (i.Quality > 50) i.Quality = 50;
    //     }

    // }

    public abstract class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public abstract void UpdateQuality();
    }

}
}