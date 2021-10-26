using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Program
    {
        IList<Item> Items;
        public static readonly int MONTH = 31;
        public static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
            {
                Items = new List<Item>
                {
                    new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                    new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                    new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                    new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
                    new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },

                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 10,
                        Quality = 49
                    },
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 5,
                        Quality = 49
                    },
                    // this conjured item does not work properly yet
                    new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
                }
            };

                for (var i = 0; i < Program.MONTH; i++)
                {
                    Console.WriteLine("-------- day " + i + " --------");
                    Console.WriteLine("name, sellIn, quality");

                    for (var j = 0; j < app.Items.Count; j++)
                    {
                        Console.WriteLine(app.Items[j].Name + ", " + app.Items[j].SellIn + ", " + app.Items[j].Quality);
                        
                        app.UpdateQuality(app.Items[j]);
                        app.UpdateSellIn(app.Items[j]);
                    }

                    Console.WriteLine("");
                }

        }

        public void UpdateSellIn(Item i){
            i.SellIn--;
        }

        public void UpdateQuality(Item i)
        {
            //1 for no, 2 for yes
            var AmIConjured = 1;
            if(i.Name.StartsWith("Conjured")) AmIConjured = 2;

                switch (i.Name)
                {

                    case "Aged Brie":
                        i.Quality++;
    
                    break;

                    case "Backstage passes to a TAFKAL80ETC concert":
                        if(i.SellIn < 11) i.Quality++;
                        if(i.SellIn < 6) i.Quality++;
                        
                        i.Quality++;

                        if(i.SellIn < 0) i.Quality = 0;
                    break;

                    case "Sulfuras, Hand of Ragnaros":
        
                    break;

                    default:
                        if (i.SellIn < 0) i.Quality -= AmIConjured;
                        i.Quality -= AmIConjured;
                    break;
                }
            
            if (i.Quality < 0) i.Quality = 0;
            if (i.Quality > 50) i.Quality = 50;
        }

    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }

}