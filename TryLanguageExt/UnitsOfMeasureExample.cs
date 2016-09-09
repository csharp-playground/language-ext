
using LanguageExt;
using static LanguageExt.Prelude;
using LanguageExt.UnitsOfMeasure;
using Xunit;

public class UnitsOfMeasureExample
{
    [Fact]
    public void SpeedTest()
    {
        var v = 100 * mph;
        var t = 50 * miles / v;
        var l = v * (4 * hours);
        Assert.True(t == 30 * mins);
        Assert.True(l == 400 * miles);
    }

    [Fact]
    public void Equality()
    {
        Assert.True(100 * cm == 1 * m);
        Assert.True(1 * km == 1000 * m);
    }
    [Fact]
    public void LengthEqualityTest() {
        Assert.True(100.Centimetres() == 1.Metres());
        Assert.True(1.Kilometres() == 1000.Metres());
    }
}