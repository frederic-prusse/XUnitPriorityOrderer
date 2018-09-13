// Set the orderer
using System.Threading;
using Xunit;
using XUnitPriorityOrderer;

namespace Tests.XUnitPriorityOrderer
{
    [Order(2)]
    public class Test1Priority2 : BaseTest
    {
        [Fact, Order(2)]
        public void Test()
        {
            Assert.Equal(1, _lastTestPriority);
            Interlocked.Increment(ref _lastTestPriority);
        }
    }
}