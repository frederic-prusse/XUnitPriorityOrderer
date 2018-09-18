using System.Threading;
using Xunit;
using XUnitPriorityOrderer;

namespace Tests.XUnitPriorityOrderer
{
    [Order(5)]
    public class Test4Priority5 : BaseTest
    {
        [Fact, Order(2)]
        public void Test2()
        {
            Assert.Equal(5, _lastTestPriority);
            Interlocked.Increment(ref _lastTestPriority);
        }

        [Fact, Order(1)]
        public void Test1()
        {
            Assert.Equal(4, _lastTestPriority);
            Interlocked.Increment(ref _lastTestPriority);
        }

        [Fact, Order(3)]
        public void Test3()
        {
            Assert.Equal(6, _lastTestPriority);
            Interlocked.Increment(ref _lastTestPriority);
        }
    }
}