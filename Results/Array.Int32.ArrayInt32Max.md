## Array.Int32.ArrayInt32Max

### Source
[ArrayInt32Max.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Max.cs)

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
|     **ForLoop** |  **Ascending** |   **100** |   **104.89 ns** |  **0.168 ns** |  **0.149 ns** |   **104.90 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
| ForeachLoop |  Ascending |   100 |   105.08 ns |  0.252 ns |  0.211 ns |   105.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|        Linq |  Ascending |   100 |   673.62 ns |  0.490 ns |  0.383 ns |   673.59 ns |  6.42 |    0.01 | 0.0076 |     - |     - |      32 B |
|      LinqAF |  Ascending |   100 | 1,426.98 ns | 28.407 ns | 65.270 ns | 1,400.00 ns | 13.82 |    0.63 |      - |     - |     - |         - |
|  StructLinq |  Ascending |   100 |   231.71 ns |  0.456 ns |  0.405 ns |   231.64 ns |  2.21 |    0.00 | 0.0076 |     - |     - |      32 B |
| CisternLinq |  Ascending |   100 |   100.51 ns |  0.482 ns |  0.427 ns |   100.31 ns |  0.96 |    0.00 |      - |     - |     - |         - |
|             |            |       |             |           |           |             |       |         |        |       |       |           |
|     **ForLoop** | **Descending** |   **100** |   **113.55 ns** |  **0.069 ns** |  **0.065 ns** |   **113.57 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
| ForeachLoop | Descending |   100 |   114.19 ns |  0.817 ns |  0.682 ns |   113.97 ns |  1.01 |    0.01 |      - |     - |     - |         - |
|        Linq | Descending |   100 |   731.08 ns | 13.518 ns | 12.645 ns |   734.58 ns |  6.44 |    0.11 | 0.0076 |     - |     - |      32 B |
|      LinqAF | Descending |   100 |   369.61 ns |  1.485 ns |  1.240 ns |   369.25 ns |  3.26 |    0.01 |      - |     - |     - |         - |
|  StructLinq | Descending |   100 |   233.29 ns |  2.198 ns |  2.056 ns |   234.01 ns |  2.05 |    0.02 | 0.0076 |     - |     - |      32 B |
| CisternLinq | Descending |   100 |    98.66 ns |  0.746 ns |  0.698 ns |    98.62 ns |  0.87 |    0.01 |      - |     - |     - |         - |
|             |            |       |             |           |           |             |       |         |        |       |       |           |
|     **ForLoop** |   **Triangle** |   **100** |   **152.91 ns** |  **2.723 ns** |  **3.136 ns** |   **151.93 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
| ForeachLoop |   Triangle |   100 |   152.48 ns |  1.732 ns |  1.620 ns |   151.85 ns |  1.00 |    0.03 |      - |     - |     - |         - |
|        Linq |   Triangle |   100 |   732.55 ns | 14.293 ns | 17.554 ns |   738.04 ns |  4.79 |    0.16 | 0.0076 |     - |     - |      32 B |
|      LinqAF |   Triangle |   100 |   407.73 ns |  7.640 ns |  7.147 ns |   409.17 ns |  2.67 |    0.06 |      - |     - |     - |         - |
|  StructLinq |   Triangle |   100 |   251.19 ns |  4.711 ns |  4.407 ns |   251.95 ns |  1.65 |    0.04 | 0.0076 |     - |     - |      32 B |
| CisternLinq |   Triangle |   100 |    99.47 ns |  1.559 ns |  1.459 ns |    98.96 ns |  0.65 |    0.02 |      - |     - |     - |         - |
