using System.Threading;
using Xunit;
using XUnitPriorityOrderer;

namespace Tests.XUnitPriorityOrderer
{
    [Order(1)]
    public class Test2Priority1 : BaseTest
    {
        [Fact, Order(1)]
        public void Test1()
        {
            Assert.Equal(0, _lastTestPriority);
            Interlocked.Increment(ref _lastTestPriority);
        }
    }
}