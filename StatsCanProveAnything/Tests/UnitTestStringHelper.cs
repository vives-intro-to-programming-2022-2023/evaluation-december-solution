using StatsCanProveAnything;

namespace Tests;

public class UnitTestStringHelper
{
    [Fact]
    public void TestGenerateCharacterLine()
    {
        Assert.Equal("", StringHelper.GenerateCharacterLine('x', 0));
        Assert.Equal("     ", StringHelper.GenerateCharacterLine(' ', 5));
        Assert.Equal("77777777", StringHelper.GenerateCharacterLine('7', 8));
        Assert.Equal("########################", StringHelper.GenerateCharacterLine('#', 24));
        Assert.Equal("", StringHelper.GenerateCharacterLine('|', -12));
    }

    [Fact]
    public void TestCenterText()
    {
        Assert.Equal("Hello", StringHelper.CenterText("Hello", -5));
        Assert.Equal("Hello", StringHelper.CenterText("Hello", 0));
        Assert.Equal("Hello", StringHelper.CenterText("Hello", 1));
        Assert.Equal("    Hello    ", StringHelper.CenterText("Hello", 13));
        Assert.Equal("    Hello   ", StringHelper.CenterText("Hello", 12));
        Assert.Equal("                  Dude This is Cool                  ", StringHelper.CenterText("Dude This is Cool", 53));
    }



}