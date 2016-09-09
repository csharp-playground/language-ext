using Xunit;
using static LanguageExt.Prelude;

public class OptionExample
{
    [Fact]
    public void CreateOption()
    {
        var optional = Some(123);
        Assert.True(optional.IsSome);
    }

    [Fact]
    public void MatchOption()
    {
        var optional = Some(123);
        var x = match(optional, Some: v => v * 2, None: () => 0);
        Assert.Equal(246, x);
    }

    [Fact]
    public void MatchWithFluentApi()
    {
        var optional = Some(123);
        var rs = optional.Some(x => x * 2).None(() => 0);
        Assert.Equal(246, rs);
    }

    [Fact]
    public void IfNone()
    {
        var opt = Optional<int>(0);
        var rs = opt.IfNone(() => 100);
        Assert.Equal(rs, 0);
    }

    [Fact]
    public void IfNone2()
    {
        Assert.Equal(100, Optional<int>(null).IfNone(() => 100));
    }

    [Fact]
    public void NoneString()
    {
        var none = Optional<string>(null).IsNone;
        Assert.True(none);
    }

    [Fact]
    public void OptionMonad()
    {
        var two = Some(2);
        var four = Some(4);
        var six = Some(6);
        var none = Optional<int>(null);

        int r = match(
            from x in two
            from y in four
            from z in six
            select x + y + z,
            Some: v => v * 2,
            None: () => 0);

        int r2 = match(
            from x in two
            from y in four
            from _ in none
            from z in six
            select x + y + z,
            Some: v => v * 2,
            None: () => 0);

        Assert.Equal(24, r);
        Assert.Equal(0, r2);

    }

    [Fact]
    public void Transfomer()
    {
        var list = List(Some(1), None, Some(2), None, Some(3));
        /*
        var presum = list.SumT();
        list = list.MapT(x => x * 2);
        var postsum = list.SumT();
        */

        /*
        var presum = list.Map(x => x.Sum()).Sum();
        list = list.Map(x => x.Map(v => v * 2));
        var postsum = list.Map(x => x.Sum()).Sum();
        */
    }
}
