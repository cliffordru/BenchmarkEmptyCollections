using BenchmarkDotNet.Attributes;
using System.Collections.ObjectModel;

namespace EmptyCollections
{
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        // Returning IReadOnlyList instead of IList to make intent clear - just consuming
        [Benchmark]
        public IReadOnlyList<User> ReadOnlyList_New()
        {
            return ReadOnlyCollection<User>.Empty;
        }

        [Benchmark]
        public IReadOnlyList<User> ReadOnlyList_Old()
        {
            return new List<User>(0);
        }

        [Benchmark]
        public IReadOnlyCollection<User> ReadOnlyCollection_New()
        {
            return ReadOnlyCollection<User>.Empty;
        }

        [Benchmark]
        public IReadOnlyCollection<User> ReadOnlyCollection_Old()
        {
            return new Collection<User>();
        }

        [Benchmark]
        public IReadOnlyDictionary<int, User> Dictionary_New()
        {
            return ReadOnlyDictionary<int, User>.Empty;
        }

        [Benchmark]
        public IReadOnlyDictionary<int, User> Dictionary_Old()
        {
            return new Dictionary<int, User>();
        }
    }
}
