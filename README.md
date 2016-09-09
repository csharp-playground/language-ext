- [x] Tuple
- [x] Option
- [x] fun expr act
- [x] Void
- [x] Immutable
- [ ] Match
- [ ] Map
- [ ] Parse
- [ ] Concurrency
- [x] Units of measure


```csharp
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

[Fact]
public void IfNone() {
    var opt = Optional<int>(0);
    var rs = opt.IfNone(() => 100);
    Assert.Equal(rs, 0);
}

[Fact]
public void IfNone2() {
    Assert.Equal(100, Optional<int>(null).IfNone(() => 100));
}
```