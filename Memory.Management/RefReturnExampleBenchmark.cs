using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using static Memory.Management.RefReturnExample;

namespace Memory.Management
{

    [MinColumn]
    [MaxColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    [MemoryDiagnoser]
    public class RefReturnExampleBenchmark
    {
        private MyStruct myStruct = new()
        {
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
        };


        [Benchmark]
        public void GetWithRef()
        {
            ref MyStruct x = ref RefReturnExample.GetWithRef(ref myStruct, ref myStruct);
        }

        [Benchmark]
        public void GetWithoutRef()
        {
            MyStruct x = RefReturnExample.GetWithoutRef(ref myStruct, ref myStruct);
        }
    }
}
