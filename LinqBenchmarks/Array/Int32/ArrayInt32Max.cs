using BenchmarkDotNet.Attributes;
using NetFabric.Hyperlinq;
using StructLinq;
using System;
using System.Linq;

namespace LinqBenchmarks.Array.Int32
{
    public class ArrayInt32Max : BenchmarkBase
    {
        int[] source;

        [Params(Shape.Ascending, Shape.Descending, Shape.Triangle)]
        public Shape DataShape { get; set; }

        public enum Shape
        {
            Ascending,
            Descending,
            Triangle,
        }

        [GlobalSetup]
        public void GlobalSetup()
            => source = DataShape switch
            {
                Shape.Ascending => System.Linq.Enumerable.Range(0, Count).ToArray(),
                Shape.Descending => System.Linq.Enumerable.Range(0, Count).Select(x => Count - x).ToArray(),
                Shape.Triangle => System.Linq.Enumerable.Concat(
                                    System.Linq.Enumerable.Range(0, Count / 2),
                                    System.Linq.Enumerable.Range(0, Count / 2).Select(x => Count - x)
                                  ).ToArray(),
                _ => throw new NotSupportedException(),
            };

        [Benchmark(Baseline = true)]
        public int ForLoop()
        {
            var max = int.MinValue;
            var array = source;
            for (var index = 0; index < array.Length; index++)
            {
                if (array[index] > max)
                    max = array[index];
            }
            return max;
        }

        [Benchmark]
        public int ForeachLoop()
        {
            var max = int.MinValue;
            foreach (var item in source)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        [Benchmark]
        public int Linq() => System.Linq.Enumerable.Max(source);

        [Benchmark]
        public int LinqAF() => global::LinqAF.ArrayExtensionMethods.Max(source);

        [Benchmark]
        public int StructLinq() => source.ToStructEnumerable().Max();

#if !NETFRAMEWORK
        [Benchmark]
        public int CisternLinq() => Cistern.ValueLinq.Enumerable.Max(source);
#endif
    }
}
