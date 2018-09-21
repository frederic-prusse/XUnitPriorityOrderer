using Xunit;
using XUnitPriorityOrderer;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
[assembly: TestCollectionOrderer(CollectionPriorityOrderer.TypeName, CollectionPriorityOrderer.AssembyName)]

namespace Tests.XUnitPriorityOrderer
{
    [TestCaseOrderer(
    CasePriorityOrderer.TypeName, 
    CasePriorityOrderer.AssembyName)]
    public class BaseTest
    {
        protected static int _lastTestPriority = 0;
    }
}