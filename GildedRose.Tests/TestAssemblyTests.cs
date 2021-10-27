using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
         Program app = new Program();

        [Fact]
        public void RunOtherMain()
        {
            Program.Main(new string[1]);
        }
        [Fact]
        public void UpdateQuality_NormalItems_SellInIsNegative()
        {
            NormalItem i = new NormalItem{Name = "Normal item", Quality = 20, SellIn = -1};
            i.UpdateQuality();
            Assert.Equal(18, i.Quality);
        }

        [Theory]
        [InlineData("Aged Brie",100, 20)]
        [InlineData("Aged Brie",1, 20)]
        [InlineData("Aged Brie",0, 20)]
        [InlineData("Aged Brie",-1,20)]
        [InlineData("Aged Brie",-100, 20)]
        public void UpdateQuality_AgedBrie(string name, int sellIn, int quality)
        {
            AgedItem i = new AgedItem{Name = name, SellIn = sellIn, Quality = quality};
            i.UpdateQuality();
            Assert.Equal(21, i.Quality);
        }

        [Theory]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", -1, 0)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", -1, 10)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", -11, 0)]
        public void UpdateQuality_BackstagePass_SellInNegative(string name, int sellIn, int quality)
        {
            BPItem i = new BPItem{Name = name, SellIn = sellIn, Quality = quality};
            i.UpdateQuality();
            Assert.Equal(0, i.Quality);
        }
        
        [Fact]
        public void UpdateQuality_BackstagePass_SellIn_11()
        {
            BPItem i = new BPItem{Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 11};
            i.UpdateQuality();
            Assert.Equal(11, i.Quality);
        }
        
        [Fact]
        public void UpdateQuality_BackstagePass_SellIn_10()
        {
            BPItem i = new BPItem{Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 10};
            i.UpdateQuality();
            Assert.Equal(12, i.Quality);
        }
        
        [Fact]
        public void UpdateQuality_BackstagePass_SellIn_5()
        {
            BPItem i = new BPItem{Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 5};
            i.UpdateQuality();
            Assert.Equal(13, i.Quality);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(-1)]
        public void UpdateQuality_LegendaryItem(int sellIn)
        {
            LegendaryItem i = new LegendaryItem{Name = "Sulfuras, Hand of Ragnaros", SellIn = sellIn};
            i.UpdateQuality();
            Assert.Equal(80, i.Quality);
        }

        [Theory]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 10)]
        [InlineData("Sulfuras, Hand of Ragnaros", 80)]
        [InlineData("Aged Brie",5)]
        [InlineData("Default item",5)]
        public void UpdateSellIn_arbitraryItems(string name, int quality)
        {
            NormalItem i = new NormalItem{Name = name, Quality = quality, SellIn = 10};
            Program.UpdateSellIn(i);
            Assert.Equal(9, i.SellIn);
        }

        [Fact]
        public void UpdateQuality_Conjured_SellInPositive()
        {
            var i = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 1, Quality = 6 };
            i.UpdateQuality();
            Assert.Equal(4, i.Quality);
        }
        [Fact]
        public void UpdateQuality_Conjured_SellINegative()
        {
            var i = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = -1, Quality = 6 };
            i.UpdateQuality();
            Assert.Equal(2, i.Quality);
        }
        [Theory]
        [InlineData("+5 Dexterity Vest", 10, 20)]
        [InlineData("Aged Brie", 2, 0)]
        [InlineData("Elixir of the Mongoose", 5, 7)]
        [InlineData("Sulfuras, Hand of Ragnaros", 0, 80)]
        [InlineData("Sulfuras, Hand of Ragnaros", -1, 80)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 15, 20)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 10, 49)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 5, 49)]
        [InlineData("Conjured Mana Cake", 3, 6 )]
        public void DefaultListTest(string name, int sellin, int quality)
        {
            var items = Program.defaultList();
            Assert.Contains(items, i =>
                i.Name == name &&
                i.SellIn == sellin &&
                i.Quality == quality
            );
        }

        // [Theory]
        // [InlineData(new Item{Name = "Conjured Mana Cake", SellIn = -1, Quality = 6 })]
        // public void DefaultListTest2(Item i)
        // {
        //     var items = defaultList();
        //     Assert.Contains(items, i =>
        //         i.Name == name &&
        //         i.SellIn == sellIn &&
        //         i.Quality == quality
        //     );
        // }




    }
}