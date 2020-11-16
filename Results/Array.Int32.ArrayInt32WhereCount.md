## Array.Int32.ArrayInt32WhereCount

### Source
[ArrayInt32WhereCount.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereCount.cs)

### References:
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- StructLinq.BCL: [0.19.2](https://www.nuget.org/packages/StructLinq.BCL/0.19.2)
- NetFabric.Hyperlinq: [3.0.0-beta26](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta26)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.630 (2004/?/20H1)
Intel Core i7 CPU 930 2.80GHz (Nehalem), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

Job=.NET Core 5.0  Runtime=.NET Core 5.0  

```
|                Method | Count |        Mean |     Error |    StdDev |      Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------ |------------:|----------:|----------:|------------:|------:|--------:|-------:|------:|------:|----------:|
|             ValueLinq |   100 |   389.28 ns |  1.536 ns |  1.361 ns |   388.96 ns |  4.72 |    0.03 |      - |     - |     - |         - |
| ValueLinq_ValueLambda |   100 |   152.65 ns |  2.477 ns |  2.317 ns |   152.14 ns |  1.85 |    0.03 |      - |     - |     - |         - |
|               ForLoop |   100 |    82.45 ns |  0.573 ns |  0.536 ns |    82.23 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|           ForeachLoop |   100 |    81.67 ns |  0.505 ns |  0.422 ns |    81.65 ns |  0.99 |    0.01 |      - |     - |     - |         - |
|                  Linq |   100 | 1,306.19 ns |  3.099 ns |  2.420 ns | 1,306.62 ns | 15.88 |    0.07 | 0.0076 |     - |     - |      32 B |
|            LinqFaster |   100 |   366.53 ns |  0.305 ns |  0.271 ns |   366.51 ns |  4.45 |    0.03 |      - |     - |     - |         - |
|                LinqAF |   100 | 2,061.36 ns | 34.858 ns | 65.471 ns | 2,100.00 ns | 25.15 |    0.98 |      - |     - |     - |         - |
|            StructLinq |   100 |   471.00 ns |  4.773 ns |  4.465 ns |   469.46 ns |  5.71 |    0.07 | 0.0153 |     - |     - |      64 B |
|  StructLinq_IFunction |   100 |   243.85 ns |  0.990 ns |  0.926 ns |   243.65 ns |  2.96 |    0.02 |      - |     - |     - |         - |
|             Hyperlinq |   100 |   338.73 ns |  5.205 ns |  4.869 ns |   340.20 ns |  4.11 |    0.06 |      - |     - |     - |         - |
