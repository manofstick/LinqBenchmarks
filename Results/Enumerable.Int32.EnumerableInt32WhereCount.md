## Enumerable.Int32.EnumerableInt32WhereCount

### Source
[EnumerableInt32WhereCount.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereCount.cs)

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
|                Method | Count |       Mean |    Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------ |-----------:|---------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|             ValueLinq |   100 | 1,110.1 ns |  3.78 ns |   2.95 ns |  1.41 |    0.01 | 0.0095 |     - |     - |      40 B |
| ValueLinq_ValueLambda |   100 |   896.8 ns |  1.41 ns |   1.18 ns |  1.14 |    0.01 | 0.0095 |     - |     - |      40 B |
|           ForeachLoop |   100 |   791.3 ns |  5.98 ns |   5.59 ns |  1.00 |    0.00 | 0.0095 |     - |     - |      40 B |
|                  Linq |   100 | 1,268.2 ns | 25.21 ns |  31.88 ns |  1.61 |    0.05 | 0.0095 |     - |     - |      40 B |
|                LinqAF |   100 | 5,302.9 ns | 96.22 ns | 158.09 ns |  6.81 |    0.23 |      - |     - |     - |      40 B |
|            StructLinq |   100 | 1,091.9 ns | 15.84 ns |  14.82 ns |  1.38 |    0.02 | 0.0229 |     - |     - |      96 B |
|  StructLinq_IFunction |   100 |   870.8 ns | 13.08 ns |  10.92 ns |  1.10 |    0.02 | 0.0095 |     - |     - |      40 B |
|             Hyperlinq |   100 | 1,052.8 ns | 20.68 ns |  28.99 ns |  1.33 |    0.04 | 0.0095 |     - |     - |      40 B |
