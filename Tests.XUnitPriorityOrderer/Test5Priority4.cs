using System.Threading;
using Xunit;
using XUnitPriorityOrderer;

namespace Tests.XUnitPriorityOrderer
{
    [Order(4)]
    public class Test5Priority4 : BaseTest
    {

        [Fact]
        public void Test()
        {
            Assert.Equal(3, _lastTestPriority);
            Interlocked.Increment(ref _lastTestPriority);
        }
    }
}