#if !NETFRAMEWORK

using BenchmarkDotNet.Attributes;
using Cistern.ValueLinq;
using StructLinq;

namespace LinqBenchmarks.Array.ValueType
{
    public partial class ArrayValueTypeWhereCount: ValueTypeArrayBenchmarkBase
    {
        [Benchmark]
        public int ValueLinq() =>
            source
            .Where(item => item.IsEven())
            .Count();

        struct IsEven : IFunc<FatValueType, bool> { public bool Invoke(FatValueType t) => t.IsEven(); }

        [Benchmark]
        public int ValueLinq_ValueLambda() =>
            source
            .Where(new IsEven())
            .Count();

        struct InIsEven : IInFunc<FatValueType, bool> { public bool Invoke(in FatValueType t) => t.IsEven(); }

        [Benchmark]
        public int ValueLinq_ValueLambda_Ref() =>
            source
            .Where(new InIsEven())
            .Count();
    }
}

#endif
