using System.Threading;
using Xunit;
using XUnitPriorityOrderer;

namespace XUnitPriorityOrderer
{
    [Order(5)]
    public class Test4Priority5 : BaseTest
    {
        [Fact, Order(5)]
        public void Test()
        {
            Assert.Equal(4, _lastTestPriority);
            Interlocked.Increment(ref _lastTestPriority);
        }
    }
}