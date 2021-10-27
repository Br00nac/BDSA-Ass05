using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        var app = new Program();

        [Fact]
        public void RunOtherMain()
        {
            Program.Main(new string[1]);
        }
    }
}