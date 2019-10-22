using System;
using System.Threading.Tasks;
using TaskTupleAwaiter;

namespace Sample
{
    public class SampleClass
    {
        public async Task SampleMethod()
        {
            (string str, Guid guid) = await (GetStringAsync(), GetGuidAsync());
        }

        private static Task<string> GetStringAsync() => Task.FromResult("Sample");

        private static Task<Guid> GetGuidAsync() => Task.FromResult(Guid.NewGuid());
    }
}