using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Memory.Management
{
    /// <summary>
    /// Local function vs Func delegate
    /// </summary>
    [MinColumn]
    [MaxColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    [MemoryDiagnoser]
    public class LocalFunctionExample
    {
        [Benchmark]
        public void MethodWithFuncDelegate()
        {
            Func<int, int, int> add = (x, y) => x + y;
            int sum = add(1, 2);
            // Console.WriteLine(sum);
        }

        [Benchmark]
        public void MethodWithLocalFunction()
        {
            int sum = Add(1, 2);
            // Console.WriteLine(sum);

            int Add(int x, int y)
            {
                return x + y;
            }
        }
    }
}
