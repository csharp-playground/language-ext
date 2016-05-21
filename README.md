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

## สร้างโปรเจคด้วย .NET CLI

```bash
dotnet new
dotnet restore
dotnet run
```

## สร้างไฟล์ project.json

```json
{
    "version": "1.0.0-*",
    "compilationOptions": {
        "emitEntryPoint": true
    },
    "dependencies": {
        "System.Runtime": "4.0.0",
        "LanguageExt.Core": "1.7.38",
        "xunit": "2.1.0",
        "xunit.runner.dnx": "2.1.0-*"
    },
    "frameworks": {
        "dnx451": {}
    },
    "testRunner": "xunit",
    "commands": {
       "test": "xunit.runner.dnx"
   }
}
```

## ตัวอย่างการใช้ LanguageExt

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

## ทดสอบ

- ยังไม่สามารถ test ด้วยคำสั่ง `dotnet test` ใช้ `dnx test` แทน

```bash
dnu restore
dnx test
```

```bash
$ dnx test
xUnit.net DNX Runner (32-bit DNX 4.5.1)
  Discovering: csharp-language-ext
  Discovered:  csharp-language-ext
  Starting:    csharp-language-ext
  Finished:    csharp-language-ext
=== TEST EXECUTION SUMMARY ===
   csharp-language-ext  Total: 1, Errors: 0, Failed: 0, Skipped: 0, Time: 0.134s
```

## Link

- https://github.com/xunit/dnx.xunit