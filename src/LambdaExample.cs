
using static LanguageExt.Prelude;
using Xunit;

public class LambdaExample
{
    [Fact]
    public void Func() {
        var add = fun((int x, int y) => x + y);
        var rs = add(1, 2);
        Assert.Equal(3, rs);
    }

    [Fact]
    public void Action() {
        var log = act((int x) => {});
        log(100);
    }

    [Fact]
    public void Expression() {
        var exp1 = expr((int x, int y) => x + y);
        Assert.Equal(5, exp1.Compile()(4, 1));
    }
}