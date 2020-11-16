## Array.ValueType.ArrayValueTypeWhereCount

### Source
[ArrayValueTypeWhereCount.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereCount.cs)

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
|                    Method | Count |       Mean |    Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------- |------ |-----------:|---------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|                 ValueLinq |   100 |   479.8 ns |  1.73 ns |   1.44 ns |   479.4 ns |  1.26 |    0.04 |      - |     - |     - |         - |
|     ValueLinq_ValueLambda |   100 |   266.0 ns |  0.92 ns |   0.81 ns |   265.8 ns |  0.70 |    0.02 |      - |     - |     - |         - |
| ValueLinq_ValueLambda_Ref |   100 |   194.8 ns |  0.84 ns |   0.78 ns |   194.8 ns |  0.51 |    0.01 |      - |     - |     - |         - |
|                   ForLoop |   100 |   380.9 ns |  7.14 ns |   9.77 ns |   378.2 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|               ForeachLoop |   100 |   503.8 ns | 11.89 ns |  35.06 ns |   505.0 ns |  1.39 |    0.07 |      - |     - |     - |         - |
|                      Linq |   100 | 1,097.3 ns | 21.86 ns |  49.34 ns | 1,107.7 ns |  2.93 |    0.13 | 0.0076 |     - |     - |      32 B |
|                LinqFaster |   100 |   448.0 ns |  8.81 ns |  12.05 ns |   452.9 ns |  1.18 |    0.05 |      - |     - |     - |         - |
|                    LinqAF |   100 | 3,464.4 ns | 69.22 ns | 131.69 ns | 3,400.0 ns |  9.15 |    0.36 |      - |     - |     - |         - |
|                StructLinq |   100 |   535.6 ns | 10.70 ns |  23.49 ns |   547.2 ns |  1.42 |    0.06 | 0.0153 |     - |     - |      64 B |
|      StructLinq_IFunction |   100 |   305.1 ns |  6.11 ns |  13.16 ns |   312.1 ns |  0.81 |    0.04 |      - |     - |     - |         - |
|                 Hyperlinq |   100 |   403.1 ns |  8.06 ns |  18.99 ns |   412.2 ns |  1.07 |    0.05 |      - |     - |     - |         - |
