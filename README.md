## สร้างโปรเจคด้วย .net cli

```
dotnet new
dotnet restore
dotnet run
```

## สร้างไฟล์ project.json

```
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

```
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
```

## ทดสอบ

- ยังไม่สามารถ test ด้วยคำสั่ง `dotnet test` ใช้ `dnx test` แทน

```
dnu restore
dnx test
```

```
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