## Array.Int32.ArrayInt32Min

### Source
[ArrayInt32Min.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Min.cs)

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
|      Method |  DataShape | Count |        Mean |     Error |    StdDev |      Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |----------- |------ |------------:|----------:|----------:|------------:|------:|--------:|-------:|------:|------:|----------:|
|     **ForLoop** |  **Ascending** |   **100** |   **112.73 ns** |  **0.110 ns** |  **0.092 ns** |   **112.71 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
| ForeachLoop |  Ascending |   100 |   113.11 ns |  0.202 ns |  0.189 ns |   113.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|        Linq |  Ascending |   100 |   776.31 ns | 15.390 ns | 16.467 ns |   780.63 ns |  6.89 |    0.16 | 0.0076 |     - |     - |      32 B |
|      LinqAF |  Ascending |   100 | 1,463.79 ns | 29.188 ns | 64.068 ns | 1,500.00 ns | 13.10 |    0.74 |      - |     - |     - |         - |
|  StructLinq |  Ascending |   100 |   243.24 ns |  4.756 ns |  6.971 ns |   241.59 ns |  2.12 |    0.05 | 0.0076 |     - |     - |      32 B |
| CisternLinq |  Ascending |   100 |    71.26 ns |  1.401 ns |  2.010 ns |    72.05 ns |  0.63 |    0.02 |      - |     - |     - |         - |
|             |            |       |             |           |           |             |       |         |        |       |       |           |
|     **ForLoop** | **Descending** |   **100** |   **110.97 ns** |  **1.572 ns** |  **1.471 ns** |   **111.93 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
| ForeachLoop | Descending |   100 |   111.03 ns |  1.884 ns |  1.762 ns |   112.03 ns |  1.00 |    0.02 |      - |     - |     - |         - |
|        Linq | Descending |   100 |   684.98 ns | 13.593 ns | 27.458 ns |   697.18 ns |  6.13 |    0.24 | 0.0076 |     - |     - |      32 B |
|      LinqAF | Descending |   100 |   382.82 ns |  7.190 ns |  6.725 ns |   383.64 ns |  3.45 |    0.07 |      - |     - |     - |         - |
|  StructLinq | Descending |   100 |   244.65 ns |  3.398 ns |  3.012 ns |   244.82 ns |  2.21 |    0.04 | 0.0076 |     - |     - |      32 B |
| CisternLinq | Descending |   100 |    70.71 ns |  1.447 ns |  2.682 ns |    71.26 ns |  0.65 |    0.03 |      - |     - |     - |         - |
|             |            |       |             |           |           |             |       |         |        |       |       |           |
|     **ForLoop** |   **Triangle** |   **100** |   **114.30 ns** |  **2.180 ns** |  **2.039 ns** |   **114.31 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
| ForeachLoop |   Triangle |   100 |   114.09 ns |  2.346 ns |  2.195 ns |   114.33 ns |  1.00 |    0.03 |      - |     - |     - |         - |
|        Linq |   Triangle |   100 |   795.20 ns | 15.959 ns | 26.221 ns |   807.09 ns |  6.95 |    0.31 | 0.0076 |     - |     - |      32 B |
|      LinqAF |   Triangle |   100 |   379.26 ns |  5.270 ns |  4.929 ns |   380.55 ns |  3.32 |    0.07 |      - |     - |     - |         - |
|  StructLinq |   Triangle |   100 |   242.88 ns |  4.803 ns |  5.899 ns |   244.01 ns |  2.12 |    0.07 | 0.0076 |     - |     - |      32 B |
| CisternLinq |   Triangle |   100 |    68.68 ns |  1.423 ns |  2.529 ns |    69.89 ns |  0.60 |    0.02 |      - |     - |     - |         - |
