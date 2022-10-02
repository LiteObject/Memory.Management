using BenchmarkDotNet.Attributes;

namespace Memory.Management
{
    public static class RefReturnExample
    {
        public static void Run()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(arr[2]);

            // In case of reference type, when we pass an argument, we make a copy of the reference
            // (to the same data) and then pass it, so the perf improvement is not that significant
            ref int refToArrayItem = ref SelectArrayItem<int>(arr, new Func<int>(() => 2));
            Console.WriteLine(refToArrayItem);
            refToArrayItem = 123;
            Console.WriteLine(arr[2]);

            // In case of value type, when we pass an argument, we make a copy of the value
            // and then pass it, so the perf improvement can be significant

        }

        public static ref T SelectArrayItem<T>(T[] array, Func<int> selectionLogic)
        {
            return ref array[selectionLogic()];
        }

        public struct MyStruct
        {
            public int One { get; set; }

            public int Two { get; set; }

            public int Three { get; set; }

            public int Four { get; set; }

            public int Five { get; set; }

            public int Six { get; set; }

            public int Seven { get; set; }

            public int Eight { get; set; }

            public int Nine { get; set; }

            public int Ten { get; set; }
        }

        [Benchmark]
        public static ref MyStruct GetWithRef(ref MyStruct one, ref MyStruct two)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 2);

            if (num > 1)
            {
                return ref two;
            }

            return ref one;
        }

        [Benchmark]
        public static MyStruct GetWithoutRef(ref MyStruct one, ref MyStruct two)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 2);

            if (num > 1)
            {
                return two;
            }

            return one;
        }
    }
}

