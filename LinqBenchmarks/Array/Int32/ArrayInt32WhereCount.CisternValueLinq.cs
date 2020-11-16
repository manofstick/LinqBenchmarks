#if !NETFRAMEWORK

using BenchmarkDotNet.Attributes;
using Cistern.ValueLinq;
using StructLinq;

namespace LinqBenchmarks.Array.Int32
{
    public partial class ArrayInt32WhereCount: ArrayInt32BenchmarkBase
    {
        [Benchmark]
        public int ValueLinq() =>
            source
            .Where(item => item.IsEven())
            .Count();

        struct IsEven : IFunc<int, bool> { public bool Invoke(int t) => t.IsEven(); }

        [Benchmark]
        public int ValueLinq_ValueLambda() =>
            source
            .Where(new IsEven())
            .Count();
    }
}

#endif