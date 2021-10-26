using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        //[Fact]
        //public void RunMain()
        //{
        //    Program.Main(new string[1]);
        //}

        [Fact]
        public void UpdateQuality_NormalItems_SellInIsPositive()
        {
            Item i = new Item{Name = "Normal item", Quality = 20, SellIn = 5};
            Program.UpdateQuality(i);
            Assert.Equal(19, i.Quality);
        }
        [Fact]
        public void UpdateQuality_NormalItems_SellInIsNegative()
        {
            Item i = new Item{Name = "Normal item", Quality = 20, SellIn = -1};
            Program.UpdateQuality(i);
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
            Item i = new Item{Name = name, SellIn = sellIn, Quality = quality};
            Program.UpdateQuality(i);
            Assert.Equal(21, i.Quality);
        }

        [Theory]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", -1, 0)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", -1, 10)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", -11, 0)]
        public void UpdateQuality_BackstagePass_SellInNegative(string name, int sellIn, int quality)
        {
            Item i = new Item{Name = name, SellIn = sellIn, Quality = quality};
            Program.UpdateQuality(i);
            Assert.Equal(0, i.Quality);
        }
        
        [Fact]
        public void UpdateQuality_BackstagePass_SellIn_11()
        {
            Item i = new Item{Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 11};
            Program.UpdateQuality(i);
            Assert.Equal(11, i.Quality);
        }
        
        [Fact]
        public void UpdateQuality_BackstagePass_SellIn_10()
        {
            Item i = new Item{Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 10};
            Program.UpdateQuality(i);
            Assert.Equal(12, i.Quality);
        }
        
        [Fact]
        public void UpdateQuality_BackstagePass_SellIn_5()
        {
            Item i = new Item{Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 5};
            Program.UpdateQuality(i);
            Assert.Equal(13, i.Quality);
        }
    }
}