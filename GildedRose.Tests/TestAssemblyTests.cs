using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        [Fact]
        public void RunMain()
        {
            Program.Main(new string[1]);
        }
    }
}