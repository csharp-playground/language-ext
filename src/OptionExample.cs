using Xunit;
using static LanguageExt.Prelude;

public class OptionExample
{
    [Fact]
    public void CreateOption() {
        var optional = Some(123);
        Assert.True(optional.IsSome);
    }

    [Fact]
    public void MatchOption() {
        var optional = Some(123);
        var x = match(optional, Some: v => v * 2, None: () => 0);
        Assert.Equal(246, x);
    }

    [Fact]
    public void MatchWithFluentApi() {
        var optional = Some(123);
        var rs = optional.Some(x => x * 2).None(() => 0);
        Assert.Equal(246, rs);
    }
}
