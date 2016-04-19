
namespace Example {

    using static LanguageExt.Prelude;
    using Xunit;

    public class LanguageExtExample {

        [Fact]
        public void TupleTest() {
            var ab = Tuple("a", "a");
            Assert.Equal(ab.Item1, ab.Item2);
        }

        [Fact]
        public void MapTupleTest() {
            var name = Tuple("Paul", "Louth");
            var rs = name.Map((f, l) => $"{f} {l}");
            Assert.Equal(rs, "Paul Louth");
        }

        [Fact]
        public void MapTupleWithMapFunctionTest() {
            var name = Tuple("Paul", "Louth");
            var rs = map(name, (f, l) => $"{f} {l}");
            Assert.Equal(rs, "Paul Louth");
        }

    }
}