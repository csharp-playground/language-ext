
using static LanguageExt.Prelude;
using Xunit;
using LanguageExt;

public class ListExample {

    [Fact]
    public void CreateList()
    {
        var test = List(1, 2, 3, 4, 5);
        Assert.Equal(15, test.Reduce((x, y) => x + y));
    }

    [Fact]
    public void CreateRange()
    {
        var input = Range(1, 5);
        Assert.Equal(15, input.Reduce((x, y) => x + y));
    }

    [Fact]
    public void Fold() {
        var input = Range(1, 5);
        Assert.Equal(20, input.Fold(5, (x, y) => x + y));
    }

    [Fact]
    public void FluentFold() {
        var input = Range(0, 5);
        var rs = input.Map(x => x + 1).Fold(5, (x, y) => x + y);
        Assert.Equal(20, rs);
    }
}
