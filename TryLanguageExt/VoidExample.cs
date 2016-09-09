
using static LanguageExt.Prelude;
using LanguageExt;
using Xunit;

public class VoidExample
{

    public Unit Empty() {
        return unit;
    }

    [Fact]
    public void Void() {
        var u = Empty();
        Assert.Equal(u, unit);
    }
}