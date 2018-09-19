using System.Threading;
using Xunit;
using XUnitPriorityOrderer;

namespace Tests.XUnitPriorityOrderer
{
    [Order(3)]
    public class Test3Priority3 : BaseTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(2, _lastTestPriority);
            Interlocked.Increment(ref _lastTestPriority);
        }
    }
}