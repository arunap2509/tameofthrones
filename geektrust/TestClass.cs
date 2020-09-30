using Xunit;

namespace TameOfThrones.geektrust
{
    public class TestClass
    {
        [Fact]
        public void ReturnsNone()
        {
            Southeros southeros = new Southeros("D:\\Coding\\DotNet\\TameOfThrones\\TextFile\\input.txt");
            Assert.Equal("None", southeros.GetRulerAndAllies());
        }

        [Fact]
        public void ReturnsKingAndAllies()
        {
            Southeros southeros = new Southeros("D:\\Coding\\DotNet\\TameOfThrones\\geektrust\\input.txt");
            Assert.Equal("SPACE LAND ICE FIRE", southeros.GetRulerAndAllies());
        }

        [Fact]
        public void ReturnsNoneAndWontMatchWithAssert()
        {
            Southeros southeros = new Southeros("D:\\Coding\\DotNet\\TameOfThrones\\TextFile\\input.txt");
            Assert.NotEqual("SPACE LAND AIR", southeros.GetRulerAndAllies());
        }
    }
}